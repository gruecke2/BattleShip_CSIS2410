using System.Windows.Forms;

namespace Battleship_WIP
{
    partial class TestForm
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
            this.LeftBoard = new System.Windows.Forms.TableLayoutPanel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.RightBoard = new System.Windows.Forms.TableLayoutPanel();
            this.fireButton = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftBoard
            // 
            this.LeftBoard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LeftBoard.BackColor = System.Drawing.Color.Transparent;
            this.LeftBoard.ColumnCount = 10;
            this.LeftBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LeftBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LeftBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LeftBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LeftBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LeftBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LeftBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LeftBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LeftBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LeftBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LeftBoard.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.LeftBoard.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.LeftBoard.Location = new System.Drawing.Point(31, 32);
            this.LeftBoard.Margin = new System.Windows.Forms.Padding(2);
            this.LeftBoard.Name = "LeftBoard";
            this.LeftBoard.RowCount = 10;
            this.LeftBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LeftBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LeftBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LeftBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LeftBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LeftBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LeftBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LeftBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LeftBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LeftBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LeftBoard.Size = new System.Drawing.Size(310, 310);
            this.LeftBoard.TabIndex = 1;
            // 
            // panelLeft
            // 
            this.panelLeft.BackgroundImage = global::Battleship_WIP.Properties.Resources.emptyOcean1;
            this.panelLeft.Controls.Add(this.LeftBoard);
            this.panelLeft.Location = new System.Drawing.Point(33, 77);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(373, 364);
            this.panelLeft.TabIndex = 2;
            // 
            // panelRight
            // 
            this.panelRight.BackgroundImage = global::Battleship_WIP.Properties.Resources.emptyOcean2;
            this.panelRight.Controls.Add(this.RightBoard);
            this.panelRight.Location = new System.Drawing.Point(575, 77);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(372, 369);
            this.panelRight.TabIndex = 3;
            // 
            // RightBoard
            // 
            this.RightBoard.BackColor = System.Drawing.Color.Transparent;
            this.RightBoard.ColumnCount = 10;
            this.RightBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.RightBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.RightBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.RightBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.RightBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.RightBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.RightBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.RightBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.RightBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.RightBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.RightBoard.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.RightBoard.Location = new System.Drawing.Point(31, 32);
            this.RightBoard.Name = "RightBoard";
            this.RightBoard.RowCount = 10;
            this.RightBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.RightBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.RightBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.RightBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.RightBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.RightBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.RightBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.RightBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.RightBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.RightBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.RightBoard.Size = new System.Drawing.Size(314, 310);
            this.RightBoard.TabIndex = 2;
            // 
            // fireButton
            // 
            this.fireButton.Location = new System.Drawing.Point(427, 337);
            this.fireButton.Name = "fireButton";
            this.fireButton.Size = new System.Drawing.Size(126, 82);
            this.fireButton.TabIndex = 4;
            this.fireButton.Text = "Fire!";
            this.fireButton.UseVisualStyleBackColor = true;
            this.fireButton.Click += new System.EventHandler(this.FireButton_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 580);
            this.Controls.Add(this.fireButton);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        public void AddLeftButtons()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    RadioButton b = new RadioButton();
                    b.Appearance = System.Windows.Forms.Appearance.Button;
                    b.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
                  //  b.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
                    
                    b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    b.Size = new System.Drawing.Size(28, 28);
                    b.CheckedChanged += new System.EventHandler(this.LeftGrid_CheckedChanged);
                    LeftBoard.Controls.Add(b, i, j);
                    

                    leftButtons[i, j] = b;
                }
            }
        }

        public void AddRighttButtons()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    RadioButton b = new RadioButton();
                    b.Appearance = System.Windows.Forms.Appearance.Button;
                    b.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
                   // b.FlatAppearance.BorderColor = System.Drawing.Color.Silver;

                    b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    b.Size = new System.Drawing.Size(28, 28);
                    b.CheckedChanged += new System.EventHandler(this.RightGrid_CheckedChanged);
                    RightBoard.Controls.Add(b, i, j);
                   
                    rightButtons[i, j] = b;
                }
            }
        }


        #endregion
        private TableLayoutPanel LeftBoard;
        private Panel panelLeft;
        private Panel panelRight;
        private TableLayoutPanel RightBoard;
        private Button fireButton;
    }
}