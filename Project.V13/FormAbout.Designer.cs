
namespace Project.V13
{
    partial class FormAbout
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelUnSName = new System.Windows.Forms.Label();
            this.labelUnName = new System.Windows.Forms.Label();
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.kryptonPalette_MAG = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.buttonOK_MAG = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.Location = new System.Drawing.Point(167, 45);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(337, 18);
            this.labelInfo.TabIndex = 4;
            this.labelInfo.Text = "Программа разработана в рамках изучения C#";
            // 
            // labelUnSName
            // 
            this.labelUnSName.AutoSize = true;
            this.labelUnSName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUnSName.Location = new System.Drawing.Point(191, 131);
            this.labelUnSName.Name = "labelUnSName";
            this.labelUnSName.Size = new System.Drawing.Size(0, 18);
            this.labelUnSName.TabIndex = 6;
            // 
            // labelUnName
            // 
            this.labelUnName.AutoSize = true;
            this.labelUnName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUnName.Location = new System.Drawing.Point(357, 216);
            this.labelUnName.Name = "labelUnName";
            this.labelUnName.Size = new System.Drawing.Size(147, 18);
            this.labelUnName.TabIndex = 7;
            this.labelUnName.Text = "ТИУ, ВШЦТ (с) 2023";
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGroup.Location = new System.Drawing.Point(167, 27);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(137, 18);
            this.labelGroup.TabIndex = 8;
            this.labelGroup.Text = "Группа: ПКТб-23-1";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(167, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(199, 18);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "Разработчик: Мелехов А.Г.";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // pictureBoxAvatar
            // 
            this.pictureBoxAvatar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar.Image")));
            this.pictureBoxAvatar.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.Size = new System.Drawing.Size(149, 222);
            this.pictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar.TabIndex = 3;
            this.pictureBoxAvatar.TabStop = false;
            // 
            // kryptonPalette_MAG
            // 
            this.kryptonPalette_MAG.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.kryptonPalette_MAG.ButtonSpecs.FormClose.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette_MAG.ButtonSpecs.FormClose.Image")));
            this.kryptonPalette_MAG.ButtonSpecs.FormClose.ImageStates.ImageTracking = ((System.Drawing.Image)(resources.GetObject("kryptonPalette_MAG.ButtonSpecs.FormClose.ImageStates.ImageTracking")));
            this.kryptonPalette_MAG.ButtonSpecs.FormMax.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette_MAG.ButtonSpecs.FormMax.Image")));
            this.kryptonPalette_MAG.ButtonSpecs.FormMin.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette_MAG.ButtonSpecs.FormMin.Image")));
            this.kryptonPalette_MAG.ButtonSpecs.FormMin.ImageStates.ImageTracking = ((System.Drawing.Image)(resources.GetObject("kryptonPalette_MAG.ButtonSpecs.FormMin.ImageStates.ImageTracking")));
            this.kryptonPalette_MAG.ButtonSpecs.FormRestore.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette_MAG.ButtonSpecs.FormRestore.Image")));
            this.kryptonPalette_MAG.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette_MAG.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette_MAG.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette_MAG.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            this.kryptonPalette_MAG.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette_MAG.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette_MAG.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette_MAG.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            this.kryptonPalette_MAG.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette_MAG.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette_MAG.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette_MAG.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            this.kryptonPalette_MAG.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.kryptonPalette_MAG.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.kryptonPalette_MAG.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette_MAG.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette_MAG.FormStyles.FormMain.StateCommon.Border.Rounding = 16;
            this.kryptonPalette_MAG.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.kryptonPalette_MAG.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.kryptonPalette_MAG.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 12;
            this.kryptonPalette_MAG.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // buttonOK_MAG
            // 
            this.buttonOK_MAG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOK_MAG.Location = new System.Drawing.Point(540, 199);
            this.buttonOK_MAG.Name = "buttonOK_MAG";
            this.buttonOK_MAG.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.buttonOK_MAG.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.buttonOK_MAG.OverrideDefault.Back.ColorAngle = 45F;
            this.buttonOK_MAG.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(10)))));
            this.buttonOK_MAG.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(10)))));
            this.buttonOK_MAG.OverrideDefault.Border.ColorAngle = 45F;
            this.buttonOK_MAG.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonOK_MAG.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonOK_MAG.OverrideDefault.Border.Rounding = 20;
            this.buttonOK_MAG.OverrideDefault.Border.Width = 1;
            this.buttonOK_MAG.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.buttonOK_MAG.Size = new System.Drawing.Size(50, 50);
            this.buttonOK_MAG.StateCommon.Back.Color1 = System.Drawing.Color.LightGray;
            this.buttonOK_MAG.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.buttonOK_MAG.StateCommon.Back.ColorAngle = 45F;
            this.buttonOK_MAG.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.buttonOK_MAG.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.buttonOK_MAG.StateCommon.Border.ColorAngle = 45F;
            this.buttonOK_MAG.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonOK_MAG.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonOK_MAG.StateCommon.Border.Rounding = 20;
            this.buttonOK_MAG.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.buttonOK_MAG.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.buttonOK_MAG.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK_MAG.StatePressed.Back.Color1 = System.Drawing.Color.LightGray;
            this.buttonOK_MAG.StatePressed.Back.Color2 = System.Drawing.Color.DarkGray;
            this.buttonOK_MAG.StatePressed.Back.ColorAngle = 130F;
            this.buttonOK_MAG.StatePressed.Border.Color1 = System.Drawing.Color.LightGray;
            this.buttonOK_MAG.StatePressed.Border.Color2 = System.Drawing.Color.DarkGray;
            this.buttonOK_MAG.StatePressed.Border.ColorAngle = 130F;
            this.buttonOK_MAG.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonOK_MAG.StatePressed.Border.Rounding = 20;
            this.buttonOK_MAG.StatePressed.Border.Width = 1;
            this.buttonOK_MAG.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.buttonOK_MAG.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.buttonOK_MAG.StateTracking.Back.Color1 = System.Drawing.Color.LightGray;
            this.buttonOK_MAG.StateTracking.Back.Color2 = System.Drawing.Color.DarkGray;
            this.buttonOK_MAG.StateTracking.Back.ColorAngle = 45F;
            this.buttonOK_MAG.StateTracking.Border.Color1 = System.Drawing.Color.LightGray;
            this.buttonOK_MAG.StateTracking.Border.Color2 = System.Drawing.Color.DarkGray;
            this.buttonOK_MAG.StateTracking.Border.ColorAngle = 45F;
            this.buttonOK_MAG.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonOK_MAG.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonOK_MAG.StateTracking.Border.Rounding = 20;
            this.buttonOK_MAG.StateTracking.Border.Width = 1;
            this.buttonOK_MAG.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.buttonOK_MAG.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.buttonOK_MAG.TabIndex = 11;
            this.buttonOK_MAG.Values.Text = "OK";
            this.buttonOK_MAG.Click += new System.EventHandler(this.buttonOK_MAG_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(602, 261);
            this.Controls.Add(this.buttonOK_MAG);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelUnSName);
            this.Controls.Add(this.labelUnName);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBoxAvatar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelUnSName;
        private System.Windows.Forms.Label labelUnName;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBoxAvatar;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette_MAG;
        private ComponentFactory.Krypton.Toolkit.KryptonButton buttonOK_MAG;
    }
}