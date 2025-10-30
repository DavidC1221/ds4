using CalcWinForms.Data;
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace CalcWinForms.Forms
{
    public class MainForm : Form
    {
        // --- Estado ---
        private TextBox display;
        private string currentInput = "0";
        private double? accumulator = null;
        private string lastOp = null;   // "+", "-", "*", "/"
        private bool overwrite = true;  // el próximo dígito reemplaza

        private readonly CalculosRepository repo = new CalculosRepository();

        public MainForm()
        {
            // --- Ventana ---
            Text = "Calculadora";
            Width = 380;
            Height = 680;
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            // --- Display ---
            display = new TextBox
            {
                ReadOnly = true,
                TextAlign = HorizontalAlignment.Right,
                Font = new Font("Segoe UI", 28f, FontStyle.Bold),
                Dock = DockStyle.Top,
                Height = 90,
                Text = "0",
                Margin = new Padding(6)
            };
            Controls.Add(display);

            // --- Grid principal ---
            var grid = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 4,
                RowCount = 7,
                Padding = new Padding(10),
                Margin = new Padding(0, 5, 0, 0)
            };
            // Columnas (25% cada una)
            for (int i = 0; i < 4; i++)
                grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
            // 1ª fila fija (controles) + resto proporcional
            grid.RowStyles.Add(new RowStyle(SizeType.Absolute, 80));
            for (int i = 1; i < 7; i++)
                grid.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / 6));
            Controls.Add(grid);

            // --- Layout compacto: 7 filas x 4 columnas ---
            // ("" = hueco; "Historial" y "=" ocupan 2 columnas cada uno)
            string[,] L = new string[7, 4]
            {
                { "Bksp", "CE", "C", "x²" },
                { "sin",  "log10", "√x", "" },
                { "7", "8", "9", "/" },
                { "4", "5", "6", "*" },
                { "1", "2", "3", "-" },
                { "±", "0", ",", "+" },
                { "Historial", "Historial", "=", "=" }
            };

            // --- Creación de botones por layout ---
            for (int r = 0; r < 7; r++)
            {
                for (int c = 0; c < 4; c++)
                {
                    string label = L[r, c];
                    if (string.IsNullOrEmpty(label)) { grid.Controls.Add(new Panel(), c, r); continue; }

                    var btn = NewButton(label);

                    // Span para "Historial" y "=" en la última fila
                    if (r == 6 && (c == 0 || c == 2))
                    {
                        grid.Controls.Add(btn, c, r);
                        grid.SetColumnSpan(btn, 2);
                        // saltar la siguiente celda del span
                        c++;
                    }
                    else
                    {
                        grid.Controls.Add(btn, c, r);
                    }

                    btn.Click += OnButtonClick;
                }
            }
        }

        // ---------- UI helpers ----------
        private Button NewButton(string text) => new Button
        {
            Text = text == "Bksp" ? "Bksp ⌫" : text,
            Dock = DockStyle.Fill,
            Font = new Font("Segoe UI", 16f),
            TextAlign = ContentAlignment.MiddleCenter,
            UseVisualStyleBackColor = true,
            Margin = new Padding(6)
        };

        private void UpdateDisplay() => display.Text = currentInput;

        private double ParseInput()
        {
            double v; double.TryParse(currentInput, out v); return v;
        }

        // ---------- Handler único ----------
        private void OnButtonClick(object sender, EventArgs e)
        {
            var text = ((Button)sender).Text;

            // Normalizamos algunos textos
            if (text.StartsWith("Bksp")) text = "Bksp";
            if (text == ",") text = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;

            // Dígitos
            int d; if (int.TryParse(text, out d) && d >= 0 && d <= 9) { PressDigit(text); return; }

            // Operaciones y acciones
            switch (text)
            {
                case "Bksp": Backspace(); break;
                case "CE": ClearEntry(); break;
                case "C": ClearAll(); break;
                case "x²": Unary("^2", x => x * x); break;
                case "√x": Unary("√", x => x < 0 ? double.NaN : Math.Sqrt(x)); break;
                case "sin": Unary("sin", Math.Sin); break;
                case "log10": Unary("log10", x => x <= 0 ? double.NaN : Math.Log10(x)); break;
                case "±": ToggleSign(); break;
                case "+": case "-": case "*": case "/": ApplyOperator(text); break;
                case "=": Equal(); break;
                case "Historial": new HistoryForm().ShowDialog(); break;
                default:
                    // Separador decimal (., , según cultura)
                    if (text == CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                    {
                        if (!currentInput.Contains(text))
                        {
                            currentInput += text;
                            overwrite = false;
                            UpdateDisplay();
                        }
                    }
                    break;
            }
        }

        // ---------- Acciones básicas ----------
        private void PressDigit(string d)
        {
            if (overwrite || currentInput == "0") currentInput = d;
            else currentInput += d;
            overwrite = false;
            UpdateDisplay();
        }

        private void Backspace()
        {
            if (!string.IsNullOrEmpty(currentInput))
                currentInput = (currentInput.Length > 1) ? currentInput.Substring(0, currentInput.Length - 1) : "0";
            overwrite = false;
            UpdateDisplay();
        }

        private void ClearEntry()
        {
            currentInput = "0"; overwrite = true; UpdateDisplay();
        }

        private void ClearAll()
        {
            accumulator = null; lastOp = null; currentInput = "0"; overwrite = true; UpdateDisplay();
        }

        private void ToggleSign()
        {
            if (currentInput.StartsWith("-")) currentInput = currentInput.Substring(1);
            else if (currentInput != "0") currentInput = "-" + currentInput;
            overwrite = false; UpdateDisplay();
        }

        // ---------- Operaciones ----------
        private void Unary(string name, Func<double, double> f)
        {
            var x = ParseInput();
            var r = f(x);
            var txt = (double.IsNaN(r) || double.IsInfinity(r)) ? "Error" : r.ToString();
            currentInput = txt; overwrite = true; UpdateDisplay();

            string expr = (name == "√") ? "√(" + x + ")" :
                          (name == "^2") ? "(" + x + ")^2" :
                          name + "(" + x + ")";
            repo.Insert(expr, currentInput);
        }

        private void ApplyOperator(string op)
        {
            var value = ParseInput();
            if (accumulator == null)
            {
                accumulator = value;
            }
            else if (lastOp != null && !overwrite)
            {
                accumulator = Compute(accumulator.Value, value, lastOp);
                currentInput = (accumulator.HasValue ? accumulator.Value.ToString() : "Error");
                UpdateDisplay();
            }
            lastOp = op; overwrite = true;
        }

        private void Equal()
        {
            if (lastOp == null) return;
            var value = ParseInput();
            var a = accumulator.HasValue ? accumulator.Value : 0;
            var result = Compute(a, value, lastOp);
            var resultText = (double.IsNaN(result) || double.IsInfinity(result)) ? "Error" : result.ToString();

            string expr = a + " " + lastOp + " " + value;
            repo.Insert(expr, resultText);

            currentInput = resultText; accumulator = null; lastOp = null; overwrite = true; UpdateDisplay();
        }

        private double Compute(double a, double b, string op)
        {
            switch (op)
            {
                case "+": return a + b;
                case "-": return a - b;
                case "*": return a * b;
                case "/": return b == 0 ? double.NaN : a / b;
                default: return b;
            }
        }
    }
}
