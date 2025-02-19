namespace FRMVarios
{
    partial class FRMVarios
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DTPFechaNacimiento = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            DTPCalculo = new DateTimePicker();
            tableLayoutPanel1 = new TableLayoutPanel();
            BTNCalcular = new Button();
            BTNCurp = new Button();
            TXTCurp = new TextBox();
            label3 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // DTPFechaNacimiento
            // 
            DTPFechaNacimiento.Location = new Point(3, 34);
            DTPFechaNacimiento.Name = "DTPFechaNacimiento";
            DTPFechaNacimiento.Size = new Size(312, 27);
            DTPFechaNacimiento.TabIndex = 0;
            DTPFechaNacimiento.ValueChanged += DTPFecjaNacimiento_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 1;
            label1.Text = "Fecha de Nacimiento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 82);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 3;
            label2.Text = "Fecha de Calculo:";
            // 
            // DTPCalculo
            // 
            DTPCalculo.Enabled = false;
            DTPCalculo.Location = new Point(3, 121);
            DTPCalculo.Name = "DTPCalculo";
            DTPCalculo.Size = new Size(312, 27);
            DTPCalculo.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(DTPCalculo, 0, 3);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(DTPFechaNacimiento, 0, 1);
            tableLayoutPanel1.Controls.Add(BTNCalcular, 1, 4);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 37.80488F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 62.19512F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.Size = new Size(768, 216);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // BTNCalcular
            // 
            BTNCalcular.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BTNCalcular.Enabled = false;
            BTNCalcular.Location = new Point(387, 183);
            BTNCalcular.Name = "BTNCalcular";
            BTNCalcular.Size = new Size(378, 29);
            BTNCalcular.TabIndex = 4;
            BTNCalcular.Text = "Calcular";
            BTNCalcular.UseVisualStyleBackColor = true;
            BTNCalcular.Click += BTNCalcular_Click;
            // 
            // BTNCurp
            // 
            BTNCurp.Location = new Point(301, 320);
            BTNCurp.Name = "BTNCurp";
            BTNCurp.Size = new Size(94, 29);
            BTNCurp.TabIndex = 5;
            BTNCurp.Text = "CURP";
            BTNCurp.UseVisualStyleBackColor = true;
            BTNCurp.Click += BTNCurp_Click;
            // 
            // TXTCurp
            // 
            TXTCurp.Location = new Point(11, 277);
            TXTCurp.Name = "TXTCurp";
            TXTCurp.Size = new Size(384, 27);
            TXTCurp.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 249);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 7;
            label3.Text = "CURP";
            // 
            // FRMVarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 399);
            Controls.Add(label3);
            Controls.Add(TXTCurp);
            Controls.Add(BTNCurp);
            Controls.Add(tableLayoutPanel1);
            Name = "FRMVarios";
            Text = "Fechas";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker DTPFechaNacimiento;
        private Label label1;
        private Label label2;
        private DateTimePicker DTPCalculo;
        private TableLayoutPanel tableLayoutPanel1;
        private Button BTNCalcular;
        private Button BTNCurp;
        private TextBox TXTCurp;
        private Label label3;
    }
}
