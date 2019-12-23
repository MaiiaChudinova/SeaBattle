namespace SeaBattle
{
    /// <summary>
    /// A class responsible for logic interaction between objects
    /// inhrited from <see cref="PlayerController"/>
    /// </summary>
    public class InteractionController
    {
        #region Private fields

        private PlayerController p1;
        private PlayerController p2;

        private ShipDistribution p1Ship;
        private ShipDistribution p2Ship;

        // to know whether the game is over
        private int p1ShipLeft;
        private int p2ShipLeft;

        #endregion

        #region Constructor


        #endregion

        #region Public methods

        public void AcceptMove(PlayerController sender, int x, int y)
        {
            PlayerController playerToShoot = sender == p1 ? p2 : p1;
            ShipDistribution fieldToShoot = sender == p1 ? p2Ship : p1Ship;

            FieldCellState newState = FieldCellState.Empty;

            Ship curShip = fieldToShoot[x, y];

            if (curShip != null)
            {
                // shot or killed

                curShip.TakeShot();
                if (!curShip.IsAlive)
                {
                    // killed
                    newState = FieldCellState.HitKilled;

                    // is ship horizontal?
                    if (fieldToShoot[x, y - 1] == curShip ||
                        fieldToShoot[x, y + 1] == curShip)

                        for (int j = y - curShip.Size + 1; j < y + curShip.Size; ++j)
                        {
                            if (fieldToShoot[x,j] == curShip)
                            {
                                sender.ReceiveUpdate(x, j, newState, playerToShoot);
                                playerToShoot.ReceiveUpdate(x, j, newState, playerToShoot);
                            }
                        }

                    else 

                        for (int i = x - curShip.Size + 1; i < y + curShip.Size; ++i)
                        {
                            if (fieldToShoot[i, y] == curShip)
                            {
                                sender.ReceiveUpdate(i, y, newState, playerToShoot);
                                playerToShoot.ReceiveUpdate(i, y, newState, playerToShoot);
                            }
                        }

                    if (playerToShoot == p1) --p1ShipLeft;
                    else --p2ShipLeft;

                    if (p1ShipLeft < 1 || p2ShipLeft < 1) /*game over*/;

                    return;
                }
                else
                {
                    // not killed but shot
                    newState = FieldCellState.HitShot;
                }
            }

            sender.ReceiveUpdate(x, y, newState, playerToShoot);
            playerToShoot.ReceiveUpdate(x, y, newState, playerToShoot);
        }

        #endregion

    }
}
