namespace DiceRoller
{
  partial class frmDiceRoller
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
      this.LBLNumberOfDice = new System.Windows.Forms.Label();
      this.LBLDiceSize = new System.Windows.Forms.Label();
      this.LBLStatValue = new System.Windows.Forms.Label();
      this.LBLTotal = new System.Windows.Forms.Label();
      this.TxtNumberOfDice = new System.Windows.Forms.TextBox();
      this.TxtDiceSize = new System.Windows.Forms.TextBox();
      this.TxtStatValue = new System.Windows.Forms.TextBox();
      this.TxtTotal = new System.Windows.Forms.TextBox();
      this.ButCalc = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // LBLNumberOfDice
      // 
      this.LBLNumberOfDice.AutoSize = true;
      this.LBLNumberOfDice.Location = new System.Drawing.Point(237, 51);
      this.LBLNumberOfDice.Name = "LBLNumberOfDice";
      this.LBLNumberOfDice.Size = new System.Drawing.Size(81, 13);
      this.LBLNumberOfDice.TabIndex = 0;
      this.LBLNumberOfDice.Text = "Number of Dice";
      // 
      // LBLDiceSize
      // 
      this.LBLDiceSize.AutoSize = true;
      this.LBLDiceSize.Location = new System.Drawing.Point(237, 91);
      this.LBLDiceSize.Name = "LBLDiceSize";
      this.LBLDiceSize.Size = new System.Drawing.Size(52, 13);
      this.LBLDiceSize.TabIndex = 1;
      this.LBLDiceSize.Text = "Dice Size";
      // 
      // LBLStatValue
      // 
      this.LBLStatValue.AutoSize = true;
      this.LBLStatValue.Location = new System.Drawing.Point(237, 129);
      this.LBLStatValue.Name = "LBLStatValue";
      this.LBLStatValue.Size = new System.Drawing.Size(55, 13);
      this.LBLStatValue.TabIndex = 2;
      this.LBLStatValue.Text = "Stat value";
      // 
      // LBLTotal
      // 
      this.LBLTotal.AutoSize = true;
      this.LBLTotal.Location = new System.Drawing.Point(237, 218);
      this.LBLTotal.Name = "LBLTotal";
      this.LBLTotal.Size = new System.Drawing.Size(31, 13);
      this.LBLTotal.TabIndex = 3;
      this.LBLTotal.Text = "Total";
      // 
      // TxtNumberOfDice
      // 
      this.TxtNumberOfDice.Location = new System.Drawing.Point(353, 43);
      this.TxtNumberOfDice.Name = "TxtNumberOfDice";
      this.TxtNumberOfDice.Size = new System.Drawing.Size(100, 20);
      this.TxtNumberOfDice.TabIndex = 4;
      // 
      // TxtDiceSize
      // 
      this.TxtDiceSize.Location = new System.Drawing.Point(353, 83);
      this.TxtDiceSize.Name = "TxtDiceSize";
      this.TxtDiceSize.Size = new System.Drawing.Size(100, 20);
      this.TxtDiceSize.TabIndex = 5;
      // 
      // TxtStatValue
      // 
      this.TxtStatValue.Location = new System.Drawing.Point(353, 122);
      this.TxtStatValue.Name = "TxtStatValue";
      this.TxtStatValue.Size = new System.Drawing.Size(100, 20);
      this.TxtStatValue.TabIndex = 6;
      // 
      // TxtTotal
      // 
      this.TxtTotal.Location = new System.Drawing.Point(353, 211);
      this.TxtTotal.Name = "TxtTotal";
      this.TxtTotal.ReadOnly = true;
      this.TxtTotal.Size = new System.Drawing.Size(100, 20);
      this.TxtTotal.TabIndex = 7;
      // 
      // ButCalc
      // 
      this.ButCalc.Location = new System.Drawing.Point(240, 175);
      this.ButCalc.Name = "ButCalc";
      this.ButCalc.Size = new System.Drawing.Size(75, 23);
      this.ButCalc.TabIndex = 8;
      this.ButCalc.Text = "Calculate";
      this.ButCalc.UseVisualStyleBackColor = true;
      this.ButCalc.Click += new System.EventHandler(this.ButCalc_Click);
      // 
      // frmDiceRoller
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.ButCalc);
      this.Controls.Add(this.TxtTotal);
      this.Controls.Add(this.TxtStatValue);
      this.Controls.Add(this.TxtDiceSize);
      this.Controls.Add(this.TxtNumberOfDice);
      this.Controls.Add(this.LBLTotal);
      this.Controls.Add(this.LBLStatValue);
      this.Controls.Add(this.LBLDiceSize);
      this.Controls.Add(this.LBLNumberOfDice);
      this.Name = "frmDiceRoller";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label LBLNumberOfDice;
    private System.Windows.Forms.Label LBLDiceSize;
    private System.Windows.Forms.Label LBLStatValue;
    private System.Windows.Forms.Label LBLTotal;
    private System.Windows.Forms.TextBox TxtNumberOfDice;
    private System.Windows.Forms.TextBox TxtDiceSize;
    private System.Windows.Forms.TextBox TxtStatValue;
    private System.Windows.Forms.TextBox TxtTotal;
    private System.Windows.Forms.Button ButCalc;
  }
}

