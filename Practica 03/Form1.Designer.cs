namespace Practica_03
{
    partial class Form1
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
            tableLayoutPanel1 = new TableLayoutPanel();
            BTNAbrir = new Button();
            DGVTabla = new DataGridView();
            openFileDialogAbrir = new OpenFileDialog();
            menuStrip1 = new MenuStrip();
            aplicacionesToolStripMenuItem = new ToolStripMenuItem();
            variosToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVTabla).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(BTNAbrir, 0, 1);
            tableLayoutPanel1.Controls.Add(DGVTabla, 0, 0);
            tableLayoutPanel1.Location = new Point(3, 40);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 86.68172F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.318284F));
            tableLayoutPanel1.Size = new Size(864, 406);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // BTNAbrir
            // 
            BTNAbrir.Location = new Point(3, 354);
            BTNAbrir.Name = "BTNAbrir";
            BTNAbrir.Size = new Size(94, 29);
            BTNAbrir.TabIndex = 1;
            BTNAbrir.Text = "ABRIR";
            BTNAbrir.UseVisualStyleBackColor = true;
            BTNAbrir.Click += BTNAbrir_Click;
            // 
            // DGVTabla
            // 
            DGVTabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVTabla.Dock = DockStyle.Fill;
            DGVTabla.Location = new Point(3, 3);
            DGVTabla.Name = "DGVTabla";
            DGVTabla.RowHeadersWidth = 51;
            DGVTabla.Size = new Size(858, 345);
            DGVTabla.TabIndex = 2;
            // 
            // openFileDialogAbrir
            // 
            openFileDialogAbrir.FileName = "openFileDialog1";
            openFileDialogAbrir.Filter = "Archivo CSV|*.csv";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aplicacionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(872, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // aplicacionesToolStripMenuItem
            // 
            aplicacionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { variosToolStripMenuItem });
            aplicacionesToolStripMenuItem.Name = "aplicacionesToolStripMenuItem";
            aplicacionesToolStripMenuItem.Size = new Size(107, 24);
            aplicacionesToolStripMenuItem.Text = "Aplicaciones";
            // 
            // variosToolStripMenuItem
            // 
            variosToolStripMenuItem.Name = "variosToolStripMenuItem";
            variosToolStripMenuItem.Size = new Size(224, 26);
            variosToolStripMenuItem.Text = "Varios";
            variosToolStripMenuItem.Click += variosToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVTabla).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button BTNAbrir;
        private OpenFileDialog openFileDialogAbrir;
        private DataGridView DGVTabla;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aplicacionesToolStripMenuItem;
        private ToolStripMenuItem variosToolStripMenuItem;
    }
}
