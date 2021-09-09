<Query Kind="Program">
  <Namespace>System.Windows.Forms</Namespace>
  <Namespace>CalculatorImperative</Namespace>
</Query>

void Main()
{
	Application.EnableVisualStyles();
	Application.SetCompatibleTextRenderingDefault(false);
	Application.Run(new Form1());	
}

namespace CalculatorImperative
{
	partial class Form1 : Form
	{
        private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}		
		
		private System.Windows.Forms.Button btn0;
		private System.Windows.Forms.Button btn1;
		private System.Windows.Forms.Button btn2;
		private System.Windows.Forms.Button btn3;
		private System.Windows.Forms.Button btn4;
		private System.Windows.Forms.Button btn5;
		private System.Windows.Forms.Button btn6;
		private System.Windows.Forms.Button btn7;
		private System.Windows.Forms.Button btn8;
		private System.Windows.Forms.Button btn9;
		private System.Windows.Forms.Button btnSwitchSign;
		private System.Windows.Forms.Button btnDecimal;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDivide;
		private System.Windows.Forms.Button btnMultiply;
		private System.Windows.Forms.Button btnSubstract;
		private System.Windows.Forms.Button btnEquals;
		private System.Windows.Forms.Button btnSqrt;
		private System.Windows.Forms.Button btnPercent;
		private System.Windows.Forms.Button btnInverse;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnClearAll;
		private System.Windows.Forms.Button btnClearEntry;
		private System.Windows.Forms.TextBox txtScreen;

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Text = "Form1";

			this.btn0 = new System.Windows.Forms.Button();
			this.btn1 = new System.Windows.Forms.Button();
			this.btn2 = new System.Windows.Forms.Button();
			this.btn3 = new System.Windows.Forms.Button();
			this.btn4 = new System.Windows.Forms.Button();
			this.btn5 = new System.Windows.Forms.Button();
			this.btn6 = new System.Windows.Forms.Button();
			this.btn7 = new System.Windows.Forms.Button();
			this.btn8 = new System.Windows.Forms.Button();
			this.btn9 = new System.Windows.Forms.Button();
			this.btnSwitchSign = new System.Windows.Forms.Button();
			this.btnDecimal = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDivide = new System.Windows.Forms.Button();
			this.btnMultiply = new System.Windows.Forms.Button();
			this.btnSubstract = new System.Windows.Forms.Button();
			this.btnEquals = new System.Windows.Forms.Button();
			this.btnSqrt = new System.Windows.Forms.Button();
			this.btnPercent = new System.Windows.Forms.Button();
			this.btnInverse = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnClearAll = new System.Windows.Forms.Button();
			this.btnClearEntry = new System.Windows.Forms.Button();
			this.txtScreen = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btn0
			// 
			this.btn0.Location = new System.Drawing.Point(11, 289);
			this.btn0.Name = "btn0";
			this.btn0.Size = new System.Drawing.Size(50, 50);
			this.btn0.TabIndex = 0;
			this.btn0.TabStop = false;
			this.btn0.Text = "0";
			this.btn0.UseVisualStyleBackColor = true;
			this.btn0.Click += new System.EventHandler(this.btnNumber_Click);
			// 
			// btn1
			// 
			this.btn1.Location = new System.Drawing.Point(11, 233);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(50, 50);
			this.btn1.TabIndex = 1;
			this.btn1.TabStop = false;
			this.btn1.Text = "1";
			this.btn1.UseVisualStyleBackColor = true;
			this.btn1.Click += new System.EventHandler(this.btnNumber_Click);
			// 
			// btn2
			// 
			this.btn2.Location = new System.Drawing.Point(67, 233);
			this.btn2.Name = "btn2";
			this.btn2.Size = new System.Drawing.Size(50, 50);
			this.btn2.TabIndex = 2;
			this.btn2.TabStop = false;
			this.btn2.Text = "2";
			this.btn2.UseVisualStyleBackColor = true;
			this.btn2.Click += new System.EventHandler(this.btnNumber_Click);
			// 
			// btn3
			// 
			this.btn3.Location = new System.Drawing.Point(123, 233);
			this.btn3.Name = "btn3";
			this.btn3.Size = new System.Drawing.Size(50, 50);
			this.btn3.TabIndex = 3;
			this.btn3.TabStop = false;
			this.btn3.Text = "3";
			this.btn3.UseVisualStyleBackColor = true;
			this.btn3.Click += new System.EventHandler(this.btnNumber_Click);
			// 
			// btn4
			// 
			this.btn4.Location = new System.Drawing.Point(11, 177);
			this.btn4.Name = "btn4";
			this.btn4.Size = new System.Drawing.Size(50, 50);
			this.btn4.TabIndex = 4;
			this.btn4.TabStop = false;
			this.btn4.Text = "4";
			this.btn4.UseVisualStyleBackColor = true;
			this.btn4.Click += new System.EventHandler(this.btnNumber_Click);
			// 
			// btn5
			// 
			this.btn5.Location = new System.Drawing.Point(67, 177);
			this.btn5.Name = "btn5";
			this.btn5.Size = new System.Drawing.Size(50, 50);
			this.btn5.TabIndex = 5;
			this.btn5.TabStop = false;
			this.btn5.Text = "5";
			this.btn5.UseVisualStyleBackColor = true;
			this.btn5.Click += new System.EventHandler(this.btnNumber_Click);
			// 
			// btn6
			// 
			this.btn6.Location = new System.Drawing.Point(123, 177);
			this.btn6.Name = "btn6";
			this.btn6.Size = new System.Drawing.Size(50, 50);
			this.btn6.TabIndex = 6;
			this.btn6.TabStop = false;
			this.btn6.Text = "6";
			this.btn6.UseVisualStyleBackColor = true;
			this.btn6.Click += new System.EventHandler(this.btnNumber_Click);
			// 
			// btn7
			// 
			this.btn7.Location = new System.Drawing.Point(11, 121);
			this.btn7.Name = "btn7";
			this.btn7.Size = new System.Drawing.Size(50, 50);
			this.btn7.TabIndex = 7;
			this.btn7.TabStop = false;
			this.btn7.Text = "7";
			this.btn7.UseVisualStyleBackColor = true;
			this.btn7.Click += new System.EventHandler(this.btnNumber_Click);
			// 
			// btn8
			// 
			this.btn8.Location = new System.Drawing.Point(67, 121);
			this.btn8.Name = "btn8";
			this.btn8.Size = new System.Drawing.Size(50, 50);
			this.btn8.TabIndex = 8;
			this.btn8.TabStop = false;
			this.btn8.Text = "8";
			this.btn8.UseVisualStyleBackColor = true;
			this.btn8.Click += new System.EventHandler(this.btnNumber_Click);
			// 
			// btn9
			// 
			this.btn9.Location = new System.Drawing.Point(123, 121);
			this.btn9.Name = "btn9";
			this.btn9.Size = new System.Drawing.Size(50, 50);
			this.btn9.TabIndex = 9;
			this.btn9.TabStop = false;
			this.btn9.Text = "9";
			this.btn9.UseVisualStyleBackColor = true;
			this.btn9.Click += new System.EventHandler(this.btnNumber_Click);
			// 
			// btnSwitchSign
			// 
			this.btnSwitchSign.Location = new System.Drawing.Point(67, 289);
			this.btnSwitchSign.Name = "btnSwitchSign";
			this.btnSwitchSign.Size = new System.Drawing.Size(50, 50);
			this.btnSwitchSign.TabIndex = 10;
			this.btnSwitchSign.TabStop = false;
			this.btnSwitchSign.Text = "+/-";
			this.btnSwitchSign.UseVisualStyleBackColor = true;
			this.btnSwitchSign.Click += new System.EventHandler(this.btnFunction_Click);
			// 
			// btnDecimal
			// 
			this.btnDecimal.Location = new System.Drawing.Point(123, 289);
			this.btnDecimal.Name = "btnDecimal";
			this.btnDecimal.Size = new System.Drawing.Size(50, 50);
			this.btnDecimal.TabIndex = 11;
			this.btnDecimal.TabStop = false;
			this.btnDecimal.Text = ".";
			this.btnDecimal.UseVisualStyleBackColor = true;
			this.btnDecimal.Click += new System.EventHandler(this.btnFunction_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.ForeColor = System.Drawing.Color.Red;
			this.btnAdd.Location = new System.Drawing.Point(179, 289);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(50, 50);
			this.btnAdd.TabIndex = 15;
			this.btnAdd.TabStop = false;
			this.btnAdd.Text = "+";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnOperator_Click);
			// 
			// btnDivide
			// 
			this.btnDivide.ForeColor = System.Drawing.Color.Red;
			this.btnDivide.Location = new System.Drawing.Point(179, 121);
			this.btnDivide.Name = "btnDivide";
			this.btnDivide.Size = new System.Drawing.Size(50, 50);
			this.btnDivide.TabIndex = 14;
			this.btnDivide.TabStop = false;
			this.btnDivide.Text = "/";
			this.btnDivide.UseVisualStyleBackColor = true;
			this.btnDivide.Click += new System.EventHandler(this.btnOperator_Click);
			// 
			// btnMultiply
			// 
			this.btnMultiply.ForeColor = System.Drawing.Color.Red;
			this.btnMultiply.Location = new System.Drawing.Point(179, 177);
			this.btnMultiply.Name = "btnMultiply";
			this.btnMultiply.Size = new System.Drawing.Size(50, 50);
			this.btnMultiply.TabIndex = 13;
			this.btnMultiply.TabStop = false;
			this.btnMultiply.Text = "*";
			this.btnMultiply.UseVisualStyleBackColor = true;
			this.btnMultiply.Click += new System.EventHandler(this.btnOperator_Click);
			// 
			// btnSubstract
			// 
			this.btnSubstract.ForeColor = System.Drawing.Color.Red;
			this.btnSubstract.Location = new System.Drawing.Point(179, 233);
			this.btnSubstract.Name = "btnSubstract";
			this.btnSubstract.Size = new System.Drawing.Size(50, 50);
			this.btnSubstract.TabIndex = 12;
			this.btnSubstract.TabStop = false;
			this.btnSubstract.Text = "-";
			this.btnSubstract.UseVisualStyleBackColor = true;
			this.btnSubstract.Click += new System.EventHandler(this.btnOperator_Click);
			// 
			// btnEquals
			// 
			this.btnEquals.ForeColor = System.Drawing.Color.Red;
			this.btnEquals.Location = new System.Drawing.Point(235, 289);
			this.btnEquals.Name = "btnEquals";
			this.btnEquals.Size = new System.Drawing.Size(50, 50);
			this.btnEquals.TabIndex = 19;
			this.btnEquals.TabStop = false;
			this.btnEquals.Text = "=";
			this.btnEquals.UseVisualStyleBackColor = true;
			this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
			// 
			// btnSqrt
			// 
			this.btnSqrt.ForeColor = System.Drawing.Color.Blue;
			this.btnSqrt.Location = new System.Drawing.Point(235, 121);
			this.btnSqrt.Name = "btnSqrt";
			this.btnSqrt.Size = new System.Drawing.Size(50, 50);
			this.btnSqrt.TabIndex = 18;
			this.btnSqrt.TabStop = false;
			this.btnSqrt.Text = "sqrt";
			this.btnSqrt.UseVisualStyleBackColor = true;
			this.btnSqrt.Click += new System.EventHandler(this.btnFunction_Click);
			// 
			// btnPercent
			// 
			this.btnPercent.ForeColor = System.Drawing.Color.Blue;
			this.btnPercent.Location = new System.Drawing.Point(235, 177);
			this.btnPercent.Name = "btnPercent";
			this.btnPercent.Size = new System.Drawing.Size(50, 50);
			this.btnPercent.TabIndex = 17;
			this.btnPercent.TabStop = false;
			this.btnPercent.Text = "%";
			this.btnPercent.UseVisualStyleBackColor = true;
			this.btnPercent.Click += new System.EventHandler(this.btnFunction_Click);
			// 
			// btnInverse
			// 
			this.btnInverse.ForeColor = System.Drawing.Color.Blue;
			this.btnInverse.Location = new System.Drawing.Point(235, 233);
			this.btnInverse.Name = "btnInverse";
			this.btnInverse.Size = new System.Drawing.Size(50, 50);
			this.btnInverse.TabIndex = 16;
			this.btnInverse.TabStop = false;
			this.btnInverse.Text = "1/x";
			this.btnInverse.UseVisualStyleBackColor = true;
			this.btnInverse.Click += new System.EventHandler(this.btnFunction_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.ForeColor = System.Drawing.Color.Red;
			this.btnDelete.Location = new System.Drawing.Point(179, 65);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(106, 50);
			this.btnDelete.TabIndex = 24;
			this.btnDelete.TabStop = false;
			this.btnDelete.Text = "del";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnFunction_Click);
			// 
			// btnClearAll
			// 
			this.btnClearAll.ForeColor = System.Drawing.Color.Red;
			this.btnClearAll.Location = new System.Drawing.Point(68, 65);
			this.btnClearAll.Name = "btnClearAll";
			this.btnClearAll.Size = new System.Drawing.Size(105, 50);
			this.btnClearAll.TabIndex = 23;
			this.btnClearAll.TabStop = false;
			this.btnClearAll.Text = "C";
			this.btnClearAll.UseVisualStyleBackColor = true;
			this.btnClearAll.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnClearEntry
			// 
			this.btnClearEntry.ForeColor = System.Drawing.Color.Red;
			this.btnClearEntry.Location = new System.Drawing.Point(12, 65);
			this.btnClearEntry.Name = "btnClearEntry";
			this.btnClearEntry.Size = new System.Drawing.Size(50, 50);
			this.btnClearEntry.TabIndex = 22;
			this.btnClearEntry.TabStop = false;
			this.btnClearEntry.Text = "CE";
			this.btnClearEntry.UseVisualStyleBackColor = true;
			this.btnClearEntry.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// txtScreen
			// 
			this.txtScreen.BackColor = System.Drawing.SystemColors.Window;
			this.txtScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtScreen.Location = new System.Drawing.Point(12, 12);
			this.txtScreen.Name = "txtScreen";
			this.txtScreen.ReadOnly = true;
			this.txtScreen.Size = new System.Drawing.Size(274, 47);
			this.txtScreen.TabIndex = 25;
			this.txtScreen.TabStop = false;
			this.txtScreen.Text = "0.";
			this.txtScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(294, 351);
			this.Controls.Add(this.txtScreen);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnClearAll);
			this.Controls.Add(this.btnClearEntry);
			this.Controls.Add(this.btnEquals);
			this.Controls.Add(this.btnSqrt);
			this.Controls.Add(this.btnPercent);
			this.Controls.Add(this.btnInverse);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnDivide);
			this.Controls.Add(this.btnMultiply);
			this.Controls.Add(this.btnSubstract);
			this.Controls.Add(this.btnDecimal);
			this.Controls.Add(this.btnSwitchSign);
			this.Controls.Add(this.btn9);
			this.Controls.Add(this.btn8);
			this.Controls.Add(this.btn7);
			this.Controls.Add(this.btn6);
			this.Controls.Add(this.btn5);
			this.Controls.Add(this.btn4);
			this.Controls.Add(this.btn3);
			this.Controls.Add(this.btn2);
			this.Controls.Add(this.btn1);
			this.Controls.Add(this.btn0);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Imperative Calculator";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private void btnNumber_Click(object sender, EventArgs e)
		{
			Button btnNum = sender as Button;
			int numValue;
			switch (btnNum.Name)
			{
				case "btn1":
					numValue = 1;
					break;
				case "btn2":
					numValue = 2;
					break;
				case "btn3":
					numValue = 3;
					break;
				case "btn4":
					numValue = 4;
					break;
				case "btn5":
					numValue = 5;
					break;
				case "btn6":
					numValue = 6;
					break;
				case "btn7":
					numValue = 7;
					break;
				case "btn8":
					numValue = 8;
					break;
				case "btn9":
					numValue = 9;
					break;
				default:
					numValue = 0;
					break;
			}
			CalcEngine.AppendNum(numValue);
			UpdateScreen();
		}

		private void btnFunction_Click(object sender, EventArgs e)
		{
			Button btnFunction = sender as Button;
			string strValue;
			switch (btnFunction.Name)
			{
				case "btnSqrt":
					strValue = "sqrt";
					break;
				case "btnPercent":
					strValue = "percent";
					break;
				case "btnInverse":
					strValue = "inverse";
					break;
				case "btnDelete":
					strValue = "delete";
					break;
				case "btnSwitchSign":
					strValue = "switchSign";
					break;
				case "btnDecimal":
					strValue = "decimal";
					break;
				default:
					strValue = "";
					break;
			}
			CalcEngine.FunctionButton(strValue);
			UpdateScreen();
		}

		private void btnOperator_Click(object sender, EventArgs e)
		{
			Button btnOperator = sender as Button;
			string strOperator = "";
			switch (btnOperator.Name)
			{
				case "btnAdd":
					strOperator = "add";
					break;
				case "btnSubtract":
					strOperator = "subtract";
					break;
				case "btnMultiply":
					strOperator = "multiply";
					break;
				case "btnDivide":
					strOperator = "divide";
					break;
			}
			CalcEngine.PrepareOperation(
				strOperator);
			UpdateScreen();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			if (sender is System.Windows.Forms.Button)
			{
				Button btnClear = sender as Button;
				switch (btnClear.Name)
				{
					case "btnClearAll":
						CalcEngine.ClearAll();
						UpdateScreen();
						break;
					case "btnClearEntry":
						CalcEngine.Clear();
						UpdateScreen();
						break;
				}
			}
		}

		private void btnEquals_Click(object sender, EventArgs e)
		{
			// Attempt to solve the Math
			if (!CalcEngine.Solve())
			{
				btnClearAll.PerformClick();
			}
			UpdateScreen();
		}

		private void UpdateScreen()
		{
			txtScreen.Text = FormatDisplay(
				Convert.ToString(
					CalcEngine.GetDisplay()));
		}

		private string FormatDisplay(
			string str)
		{
			String dec = "";
			int totalCommas = 0;
			int pos = 0;
			bool addNegative = false;
			if (str.StartsWith("-"))
			{
				str = str.Remove(0, 1);
				addNegative = true;
			}
			if (str.IndexOf(".") > -1)
			{
				dec = str.Substring(
				str.IndexOf("."),
				str.Length - str.IndexOf("."));
				str = str.Remove(
				str.IndexOf("."),
				str.Length - str.IndexOf("."));
			}
			if (Convert.ToDouble(str) < Math.Pow(10, 19))
			{
				if (str.Length > 3)
				{
					totalCommas =
					(str.Length - (str.Length % 3)) / 3;
					if (str.Length % 3 == 0)
					{
						totalCommas--;
					}
					pos = str.Length - 3;
					while (totalCommas > 0)
					{
						str = str.Insert(pos, ",");
						pos -= 3;
						totalCommas--;
					}
				}
			}
			str += "" + dec;
			if (str.IndexOf(".") == -1)
			{
				str = str + ".";
			}
			if (str.IndexOf(".") == 0)
			{
				str.Insert(0, "0");
			}
			else if (str.IndexOf(".") ==
			str.Length - 2 &&
			str.LastIndexOf("0") ==
			str.Length - 1)
			{
				str = str.Remove(str.Length - 1);
			}
			if (addNegative)
			{
				str = str.Insert(0, "-");
			}
			return str;
		}
	}

	internal class CalcEngine
	{
		// This is the behind the scenes number
		// that represents what will be on the display
		// and what number to store as last input
		private static string m_input;
		// Sign of the number (positive or negative)
		private static string m_sign;
		// Current operator selected (+, -, * or /)
		public static String m_operator;
		// Last result displayed
		private static String m_lastNum;
		// Last input made
		private static String m_lastInput;
		// If the calculator should start a new input
		// after a number is hit
		public static bool m_wait;
		// If the user is entering in decimal values
		public static bool m_decimal;
		// If the last key that was hit was the equals button
		private static bool m_lastHitEquals;

		static CalcEngine()
		{
			// "." is used to represent no input
			// which registers as 0
			ClearAll();
		}
		// Resets all variables
		public static void ClearAll()
		{
			//Reset the calculator
			m_input = ".";
			m_lastNum = null;
			m_lastInput = null;
			m_operator = null;
			m_sign = "+";
			m_wait = false;
			m_decimal = false;
			m_lastHitEquals = false;
		}
		// For Clear Entry,
		// just reset appropriate variable
		public static void Clear()
		{
			//Just clear the current input
			m_sign = "+";
			m_input = ".";
			m_decimal = false;
		}
		// Indicate that user doesn't input value yet
		private static bool IsEmpty()
		{
			if (m_input.Equals(".") || m_wait)
				return true;
			else
				return false;
		}		
		// Appends number to the input
		public static void AppendNum(
			double numValue)
		{
			if (numValue == Math.Round(numValue) &&
				numValue >= 0)
			{
				// Append number to the input string
				if (!IsEmpty())
				{
					// if decimal is turned on
					if (m_decimal)
					{
						m_input += "" + numValue;
					}
					else
					{
						m_input = m_input.Insert(
							m_input.IndexOf("."), "" + numValue);
					}
				}
				// If nothing was entered yet, 
				// then set input equal to the number hit
				else
				{
					// Start over if the last key hit 
					// was the equals button 
					// and no operators were chosen
					if (m_lastHitEquals)
					{
						ClearAll();
						m_lastHitEquals = false;
					}

					if (m_decimal)
					{
						m_input = "." + numValue;
					}
					else
					{
						m_input = numValue + ".";
					}
					m_wait = false;
				}

				if (m_input.IndexOf("0", 0, 1) == 0 &&
					m_input.IndexOf(".") > 1)
				{
					//Get rid of any extra zeroes 
					//that may have been prepended
					m_input = m_input.Remove(0, 1);
				}
			}
			// If they're trying to append a decimal or negative, 
			// that's impossible so just replace the entire input
			// with that value
			else
			{
				// Start over if the last key hit 
				// was the equals button 
				// and no operators were chosen
				if (m_lastHitEquals)
				{
					ClearAll();
					m_lastHitEquals = false;
				}
				m_input = "" + numValue;

				// Reformat
				m_input = FormatInput(m_input);
				if (!m_input.Contains("."))
				{
					m_input += ".";
				}

				if (m_input.Contains(".") &&
					!(m_input.EndsWith("0") &&
					m_input.IndexOf(".") ==
						m_input.Length - 2))
				{
					m_decimal = true;
				}

				if (m_input.Contains("-"))
				{
					m_sign = "-";
				}
				else
				{
					m_sign = "+";
				}

				// Get rid of any extra zeroes 
				// that may have been prepended or appended
				if (m_input.IndexOf("0", 0, 1) == 0 &&
					m_input.IndexOf(".") > 1)
				{
					m_input = m_input.Remove(0, 1);
				}

				if (m_input.EndsWith("0") &&
					m_input.IndexOf(".") == m_input.Length - 2)
				{
					m_input.Remove(m_input.Length - 1);
				}

				m_wait = false;
			}
		}

		// Get display from input
		public static double GetDisplay()
		{
			return Convert.ToDouble(
				FormatInput(m_input));
		}
		
		// Handles operation functions
		public static void PrepareOperation(
			string strOperator)
		{
			switch (strOperator)
			{
				case "add":
					// If this is the first number 
					// that user inputs
					if (m_lastNum == null ||
						m_wait)
					{
						if (m_lastNum != null &&
							!m_operator.Equals("+") &&
							!m_lastHitEquals &&
							!m_wait)
							Solve();
						m_operator = "+";
						m_lastNum = "" + FormatInput(
							m_input);
						m_sign = "+";
						m_decimal = false;
						m_wait = true;
					}
					// If this is the second or higher number 
					// that user inputs
					// then update the results of the calculation
					else
					{
						if (!m_wait)
							Solve();
						m_operator = "+";
						m_sign = "+";
						m_wait = true;
					}
					m_lastHitEquals = false;
					break;
				case "subtract":
					if (m_lastNum == null || m_wait)
					{
						if (m_lastNum != null &&
							!m_operator.Equals("-") &&
							!m_lastHitEquals && !m_wait)
							Solve();
						m_operator = "-";
						m_lastNum = "" + FormatInput(m_input);
						m_sign = "+";
						m_decimal = false;
						m_wait = true;
					}
					else
					{
						if (!m_wait)
							Solve();
						m_operator = "-";
						m_sign = "+";
						m_wait = true;
					}
					m_lastHitEquals = false;
					break;
				case "multiply":
					if (m_lastNum == null || m_wait)
					{
						if (m_lastNum != null &&
							!m_operator.Equals("*") &&
							!m_lastHitEquals &&
							!m_wait)
							Solve();
						m_operator = "*";
						m_lastNum = "" + FormatInput(m_input);
						m_sign = "+";
						m_decimal = false;
						m_wait = true;
					}
					else
					{
						if (!m_wait)
							Solve();
						m_operator = "*";
						m_sign = "+";
						m_wait = true;
					}
					m_lastHitEquals = false;
					break;
				case "divide":
					if (m_lastNum == null || m_wait)
					{
						if (m_lastNum != null &&
							!m_operator.Equals("/")
							&& !m_lastHitEquals)
							Solve();
						m_operator = "/";
						m_lastNum = "" + FormatInput(m_input);
						m_sign = "+";
						m_decimal = false;
						m_wait = true;
					}
					else
					{
						if (!m_wait)
							Solve();
						m_operator = "/";
						m_sign = "+";
						m_wait = true;
					}
					m_lastHitEquals = false;
					break;
			}
		}

		// Formats the input into a valid double format
		private static string FormatInput(
			string str)
		{
			// Format the input to something convertable
			// by Convert.toDouble
			// Prepend a Zero
			// if the string begins with a "."
			if (str.IndexOf(".") == 0)
			{
				str = "0" + str;
			}
			// Appened a Zero
			// if the string ends with a "."
			if (str.IndexOf(".") ==	str.Length - 1)
			{
				str = str + "0";
			}
			// If negative is turned on
			// and there's no "-"
			// in the current string
			// then "-" is prepended
			if (m_sign.Equals("-") 
			    && str != "0.0" 
				&& str.IndexOf("-") == -1)
			{
				str = "-" + str;
			}
			return str;
		}

		// Solve the currently stored expression
		public static bool Solve()
		{
			bool canSolve = true;

			// For normal solving
			if (m_operator != null)
			{
				// Clean up
				if (m_input.Equals(""))
					m_input = "0";

				if (m_lastNum == null ||
					m_lastNum.Equals(""))
				{
					m_lastNum = "0.0";
				}

				if (!m_wait)
				{
					m_lastInput = "" + FormatInput(m_input);
				}

				// We take the previous number value 
				// and perform an operation with the current value
				String answer = "";
				switch (m_operator)
				{
					case "+":
						answer = "" + Convert.ToString(
							Convert.ToDouble(m_lastNum) +
							Convert.ToDouble(m_lastInput));
						break;
					case "-":
						answer = "" + Convert.ToString(
							Convert.ToDouble(m_lastNum) -
							Convert.ToDouble(m_lastInput));
						break;
					case "*":
						answer = "" + Convert.ToString(
							Convert.ToDouble(m_lastNum) *
							Convert.ToDouble(m_lastInput));
						break;
					case "/":
						if (!FormatInput(
							m_lastInput).Equals("0.0"))
						{
							answer = "" + Convert.ToString(
								Convert.ToDouble(m_lastNum) /
								Convert.ToDouble(m_lastInput));
						}
						break;
				}

				if (answer.Equals(""))
				{
					// The operation cannot be proceed
					canSolve = false;
				}
				else
				{
					m_lastNum = answer;
					m_input = answer;
					m_sign = "+";
					m_decimal = false;
					m_lastHitEquals = true;
					m_wait = true;
					canSolve = true;
				}
			}

			return canSolve;
		}

		// Handles decimal square roots, 
		// decimal buttons, percents, inverse, delete, 
		// and sign switching
		public static bool FunctionButton(
			string str)
		{
			bool success = false;
			switch (str)
			{
				case "sqrt":
					if (!m_sign.Equals("-"))
					{
						m_input = Convert.ToString(
							Math.Sqrt(
								Convert.ToDouble(
									m_input)));
						success = true;
					}
					else
					{
						success = false;
					}
					break;
				case "percent":
					if (m_lastNum != null)
					{
						m_input = Convert.ToString(
							Convert.ToDouble(m_lastNum) *
							(Convert.ToDouble(m_input) /
							100));
						success = true;
					}
					else
					{
						success = false;
					}
					break;
				case "inverse":
					if (Convert.ToDouble(m_input) != 0)
					{
						m_input = Convert.ToString(
							1 / Convert.ToDouble(
								m_input));
						if (Math.Abs(
							Convert.ToDouble(
								m_input)) -
							(Math.Round(
								Convert.ToDouble(
									m_input))) < .000000001)
						{
							m_input = Convert.ToString(
								Math.Round(
									Convert.ToDouble(
										m_input)));
						}
						success = true;
					}
					else
					{
						// Unable to inverse Zero.
						success = false;
					}
					break;
				case "delete":
					if (!m_input.Equals(".") &&
						!m_wait)
					{
						if (m_decimal)
						{
							m_input = m_input.Remove(
								m_input.Length - 1);
							if (m_input.IndexOf(".") < 0)
							{
								m_input += ".";
								m_decimal = false;
							}
						}
						else
						{
							m_input = m_input.Remove(
								m_input.IndexOf(".") - 1,
								1);
						}
						if (m_input.Equals(".") ||
							m_input.Equals("-."))
						{
							m_input = ".";
							m_sign = "+";
						}
						success = true;
					}
					else
					{
						// Nothing to backspace
						success = false;
					}
					break;
				case "switchSign":
					if (!m_wait &&
						!m_input.Equals("."))
					{
						if (m_sign.Equals("+") &&
							!m_input.Equals(""))
						{
							m_sign = "-";
							m_input = "-" + m_input;
						}
						else
						{
							if (m_sign.Equals("-"))
							{
								m_input = m_input.Remove(0, 1);
							}
							m_sign = "+";
						}
						success = true;
					}
					else
					{
						success = false;
					}
					break;
				case "decimal":
					if (!m_decimal)
					{
						m_decimal = true;
						success = true;
					}
					else
					{
						success = false;
					}
					break;
			}
			return success;
		}		
	}
}