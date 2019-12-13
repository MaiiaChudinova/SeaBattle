using System;

namespace SeaBattle
{
    /// <summary>
    /// A class representing a player
    /// </summary>
    public class Player
    {
        #region Private fields

        private string name;

        #endregion

        #region Constructor

        public Player(string name)
        {
            this.name = name;
        }

        #endregion

        #region Public propetries

        public string Name
        {
            get => name;
            set
            {
                if (value.Length > 60)
                    throw new Exception("Player name too long. Name length should be under 60 symbols.");
                foreach (char symbol in value)
                {
                    if (char.IsPunctuation(symbol))
                        throw new Exception("Player name should not contain any punctuation symbols.");
                }
                name = value;
            }
        }

        #endregion
    }
}
