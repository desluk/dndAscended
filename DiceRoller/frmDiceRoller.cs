using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRoller
{
  public partial class frmDiceRoller : Form
  {
    #region Global variables
    Random dice;
    #endregion


    // Very IMPORTANT!!!!!
    // At this point there is no input filters (checking that the correct things are being entered)
    // This is just a basic proof of concept.
    public frmDiceRoller()
    {
      InitializeComponent();
      
    }

    /// <summary>
    /// 
    /// Input: This will take in the number of sides that the wanted dice has
    /// 
    /// Proccess: This will create a psuedo random roll (This can be improved  but look to the first comments)
    /// 
    /// Output: The number that was Rolled by the system
    /// 
    /// </summary>
    /// <param name="diceSize"> This is an Integer</param>
    /// <returns>Number Rolled</returns>
    private int RollDice(int diceSize)
    {
      dice = new Random();
      int NumberRolled;

      NumberRolled = dice.Next(1, diceSize + 1);

      return NumberRolled;
    }
    /// <summary>
    /// Input: The number of dice that are being used,
    ///        The number of sides the wanted dice has,
    ///        The stat change of the current character.
    /// 
    /// Process: Will take the number of dice needed and use this to run through a simple loop where 
    ///          it will then create 'Random' values witht the wanted sided dice and add the stat change
    ///          as well.
    /// 
    /// Output: The final value that the player needs with the given values
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ButCalc_Click(object sender, EventArgs e)
    {
      int NumberOfDice = Convert.ToInt32(TxtNumberOfDice.Text);
      int DiceSize = Convert.ToInt32(TxtDiceSize.Text);
      int StatValue = Convert.ToInt32(TxtStatValue.Text);
      int Total = 0;

      for (int count = 0; count < NumberOfDice; count++)
      {
        int DiceRoll = RollDice(DiceSize);
        Total += DiceRoll;
      }

      TxtTotal.Text = (Total + StatValue).ToString();
    }
  }
}
