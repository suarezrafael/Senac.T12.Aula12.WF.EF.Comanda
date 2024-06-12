namespace SistemaDeComandas
{
    partial class FrmCardapio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            cyberGroupBox1 = new ReaLTaiizor.Controls.CyberGroupBox();
            btnVoltar = new ReaLTaiizor.Controls.CyberButton();
            btnEditar = new ReaLTaiizor.Controls.CyberButton();
            btnExcluir = new ReaLTaiizor.Controls.CyberButton();
            dgvCardapio = new ReaLTaiizor.Controls.PoisonDataGridView();
            btnAdicionarItem = new ReaLTaiizor.Controls.CyberButton();
            txtPesquisa = new ReaLTaiizor.Controls.CyberTextBox();
            cyberGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCardapio).BeginInit();
            SuspendLayout();
            // 
            // cyberGroupBox1
            // 
            cyberGroupBox1.Alpha = 20;
            cyberGroupBox1.BackColor = Color.Transparent;
            cyberGroupBox1.Background = true;
            cyberGroupBox1.Background_WidthPen = 3F;
            cyberGroupBox1.BackgroundPen = true;
            cyberGroupBox1.ColorBackground = Color.FromArgb(37, 52, 68);
            cyberGroupBox1.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberGroupBox1.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberGroupBox1.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberGroupBox1.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberGroupBox1.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberGroupBox1.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberGroupBox1.Controls.Add(btnVoltar);
            cyberGroupBox1.Controls.Add(btnEditar);
            cyberGroupBox1.Controls.Add(btnExcluir);
            cyberGroupBox1.Controls.Add(dgvCardapio);
            cyberGroupBox1.Controls.Add(btnAdicionarItem);
            cyberGroupBox1.Controls.Add(txtPesquisa);
            cyberGroupBox1.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberGroupBox1.ForeColor = Color.FromArgb(245, 245, 245);
            cyberGroupBox1.Lighting = false;
            cyberGroupBox1.LinearGradient_Background = false;
            cyberGroupBox1.LinearGradientPen = false;
            cyberGroupBox1.Location = new Point(3, 12);
            cyberGroupBox1.Name = "cyberGroupBox1";
            cyberGroupBox1.PenWidth = 15;
            cyberGroupBox1.RGB = false;
            cyberGroupBox1.Rounding = true;
            cyberGroupBox1.RoundingInt = 60;
            cyberGroupBox1.Size = new Size(882, 571);
            cyberGroupBox1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberGroupBox1.TabIndex = 0;
            cyberGroupBox1.Tag = "Cyber";
            cyberGroupBox1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberGroupBox1.Timer_RGB = 300;
            // 
            // btnVoltar
            // 
            btnVoltar.Alpha = 20;
            btnVoltar.BackColor = Color.Transparent;
            btnVoltar.Background = true;
            btnVoltar.Background_WidthPen = 4F;
            btnVoltar.BackgroundPen = true;
            btnVoltar.ColorBackground = Color.FromArgb(37, 52, 68);
            btnVoltar.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnVoltar.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnVoltar.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnVoltar.ColorLighting = Color.FromArgb(29, 200, 238);
            btnVoltar.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnVoltar.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnVoltar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnVoltar.Effect_1 = true;
            btnVoltar.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnVoltar.Effect_1_Transparency = 25;
            btnVoltar.Effect_2 = true;
            btnVoltar.Effect_2_ColorBackground = Color.White;
            btnVoltar.Effect_2_Transparency = 20;
            btnVoltar.Font = new Font("Arial", 11F);
            btnVoltar.ForeColor = Color.FromArgb(245, 245, 245);
            btnVoltar.Lighting = false;
            btnVoltar.LinearGradient_Background = false;
            btnVoltar.LinearGradientPen = false;
            btnVoltar.Location = new Point(105, 459);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.PenWidth = 15;
            btnVoltar.Rounding = true;
            btnVoltar.RoundingInt = 70;
            btnVoltar.Size = new Size(195, 75);
            btnVoltar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnVoltar.TabIndex = 5;
            btnVoltar.Tag = "Cyber";
            btnVoltar.TextButton = "<- Voltar";
            btnVoltar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            btnVoltar.Timer_Effect_1 = 5;
            btnVoltar.Timer_RGB = 300;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Alpha = 20;
            btnEditar.BackColor = Color.Transparent;
            btnEditar.Background = true;
            btnEditar.Background_WidthPen = 4F;
            btnEditar.BackgroundPen = true;
            btnEditar.ColorBackground = Color.FromArgb(37, 52, 68);
            btnEditar.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnEditar.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnEditar.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnEditar.ColorLighting = Color.FromArgb(29, 200, 238);
            btnEditar.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnEditar.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnEditar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnEditar.Effect_1 = true;
            btnEditar.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnEditar.Effect_1_Transparency = 25;
            btnEditar.Effect_2 = true;
            btnEditar.Effect_2_ColorBackground = Color.White;
            btnEditar.Effect_2_Transparency = 20;
            btnEditar.Font = new Font("Arial", 11F);
            btnEditar.ForeColor = Color.FromArgb(245, 245, 245);
            btnEditar.Lighting = false;
            btnEditar.LinearGradient_Background = false;
            btnEditar.LinearGradientPen = false;
            btnEditar.Location = new Point(588, 459);
            btnEditar.Name = "btnEditar";
            btnEditar.PenWidth = 15;
            btnEditar.Rounding = true;
            btnEditar.RoundingInt = 70;
            btnEditar.Size = new Size(195, 75);
            btnEditar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnEditar.TabIndex = 4;
            btnEditar.Tag = "Cyber";
            btnEditar.TextButton = "# Editar";
            btnEditar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnEditar.Timer_Effect_1 = 5;
            btnEditar.Timer_RGB = 300;
            // 
            // btnExcluir
            // 
            btnExcluir.Alpha = 20;
            btnExcluir.BackColor = Color.Transparent;
            btnExcluir.Background = true;
            btnExcluir.Background_WidthPen = 4F;
            btnExcluir.BackgroundPen = true;
            btnExcluir.ColorBackground = Color.FromArgb(37, 52, 68);
            btnExcluir.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnExcluir.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnExcluir.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnExcluir.ColorLighting = Color.FromArgb(29, 200, 238);
            btnExcluir.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnExcluir.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnExcluir.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnExcluir.Effect_1 = true;
            btnExcluir.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnExcluir.Effect_1_Transparency = 25;
            btnExcluir.Effect_2 = true;
            btnExcluir.Effect_2_ColorBackground = Color.White;
            btnExcluir.Effect_2_Transparency = 20;
            btnExcluir.Font = new Font("Arial", 11F);
            btnExcluir.ForeColor = Color.FromArgb(245, 245, 245);
            btnExcluir.Lighting = false;
            btnExcluir.LinearGradient_Background = false;
            btnExcluir.LinearGradientPen = false;
            btnExcluir.Location = new Point(378, 459);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.PenWidth = 15;
            btnExcluir.Rounding = true;
            btnExcluir.RoundingInt = 70;
            btnExcluir.Size = new Size(195, 75);
            btnExcluir.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnExcluir.TabIndex = 3;
            btnExcluir.Tag = "Cyber";
            btnExcluir.TextButton = "X Excluir";
            btnExcluir.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnExcluir.Timer_Effect_1 = 5;
            btnExcluir.Timer_RGB = 300;
            // 
            // dgvCardapio
            // 
            dgvCardapio.AllowUserToResizeRows = false;
            dgvCardapio.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvCardapio.BorderStyle = BorderStyle.None;
            dgvCardapio.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvCardapio.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCardapio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCardapio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCardapio.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCardapio.EnableHeadersVisualStyles = false;
            dgvCardapio.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvCardapio.GridColor = Color.FromArgb(255, 255, 255);
            dgvCardapio.Location = new Point(105, 228);
            dgvCardapio.Name = "dgvCardapio";
            dgvCardapio.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCardapio.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCardapio.RowHeadersWidth = 62;
            dgvCardapio.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvCardapio.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCardapio.Size = new Size(678, 225);
            dgvCardapio.TabIndex = 2;
            // 
            // btnAdicionarItem
            // 
            btnAdicionarItem.Alpha = 20;
            btnAdicionarItem.BackColor = Color.Transparent;
            btnAdicionarItem.Background = true;
            btnAdicionarItem.Background_WidthPen = 4F;
            btnAdicionarItem.BackgroundPen = true;
            btnAdicionarItem.ColorBackground = Color.FromArgb(37, 52, 68);
            btnAdicionarItem.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnAdicionarItem.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnAdicionarItem.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnAdicionarItem.ColorLighting = Color.FromArgb(29, 200, 238);
            btnAdicionarItem.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnAdicionarItem.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnAdicionarItem.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnAdicionarItem.Effect_1 = true;
            btnAdicionarItem.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnAdicionarItem.Effect_1_Transparency = 25;
            btnAdicionarItem.Effect_2 = true;
            btnAdicionarItem.Effect_2_ColorBackground = Color.White;
            btnAdicionarItem.Effect_2_Transparency = 20;
            btnAdicionarItem.Font = new Font("Arial", 11F);
            btnAdicionarItem.ForeColor = Color.FromArgb(245, 245, 245);
            btnAdicionarItem.Lighting = false;
            btnAdicionarItem.LinearGradient_Background = false;
            btnAdicionarItem.LinearGradientPen = false;
            btnAdicionarItem.Location = new Point(105, 127);
            btnAdicionarItem.Name = "btnAdicionarItem";
            btnAdicionarItem.PenWidth = 15;
            btnAdicionarItem.Rounding = true;
            btnAdicionarItem.RoundingInt = 70;
            btnAdicionarItem.Size = new Size(195, 75);
            btnAdicionarItem.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnAdicionarItem.TabIndex = 1;
            btnAdicionarItem.Tag = "Cyber";
            btnAdicionarItem.TextButton = "+ Item Cardápio";
            btnAdicionarItem.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnAdicionarItem.Timer_Effect_1 = 5;
            btnAdicionarItem.Timer_RGB = 300;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Alpha = 20;
            txtPesquisa.BackColor = Color.Transparent;
            txtPesquisa.Background_WidthPen = 3F;
            txtPesquisa.BackgroundPen = true;
            txtPesquisa.ColorBackground = Color.FromArgb(37, 52, 68);
            txtPesquisa.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            txtPesquisa.ColorLighting = Color.FromArgb(29, 200, 238);
            txtPesquisa.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtPesquisa.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtPesquisa.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtPesquisa.Font = new Font("Arial", 15F);
            txtPesquisa.ForeColor = Color.FromArgb(245, 245, 245);
            txtPesquisa.Lighting = false;
            txtPesquisa.LinearGradientPen = false;
            txtPesquisa.Location = new Point(105, 48);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.PenWidth = 15;
            txtPesquisa.RGB = false;
            txtPesquisa.Rounding = true;
            txtPesquisa.RoundingInt = 60;
            txtPesquisa.Size = new Size(678, 60);
            txtPesquisa.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtPesquisa.TabIndex = 0;
            txtPesquisa.Tag = "Cyber";
            txtPesquisa.TextButton = "";
            txtPesquisa.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtPesquisa.Timer_RGB = 300;
            // 
            // FrmCardapio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 595);
            Controls.Add(cyberGroupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCardapio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCardapio";
            cyberGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCardapio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox1;
        private ReaLTaiizor.Controls.CyberButton btnEditar;
        private ReaLTaiizor.Controls.CyberButton btnExcluir;
        private ReaLTaiizor.Controls.PoisonDataGridView dgvCardapio;
        private ReaLTaiizor.Controls.CyberButton btnAdicionarItem;
        private ReaLTaiizor.Controls.CyberTextBox txtPesquisa;
        private ReaLTaiizor.Controls.CyberButton btnVoltar;
    }
}