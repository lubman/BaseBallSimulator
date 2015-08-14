using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballSimulator1
{


    public enum PitchResults { Strike, Ball, FoulBall, Single, Double, Triple, HomeRun, GroundOut };

    
    public class AtBat
    {

        int _strikes = 0;
        int _balls = 0;
        Random rand = new Random();
        public enum AtBatResult { Hit, Walk, Out };

        public AtBatResult SimulateAtBat(I_Batter batter)
        {


            while (_strikes < 3 && _balls < 4)
            {
                PitchResults res = batter.HandlePitch();
                if (res == PitchResults.Ball)
                {
                    _balls++;
                }
                if (res == PitchResults.FoulBall)
                {
                    if (_strikes < 2)
                    {
                        _strikes++;
                    }
                }

                if (res == PitchResults.Strike)
                {
                    _strikes++;
                }

                if (res == PitchResults.Single)
                {
                    return AtBatResult.Hit;
                }
            }

            if (_strikes == 3)
            {
                return AtBatResult.Out;
            }
            //if (_balls == 4)
            //{
            return AtBatResult.Walk;
            //}
        }

    }

    public interface I_Batter
    {

        PitchResults HandlePitch();

    }

    public class SimpleBatter : I_Batter
    {
        //This is a simple batter that hits in proportion to batting average irrespective of game state

        Random r = new Random(Guid.NewGuid().GetHashCode());

        double _ballStruckPct = 0.4;
        double _foulPct = 0.4;
        double _hitPct = 0.1;


        double _ballPct = 0.38;
        //   double _hitPct=0.061;
        public SimpleBatter(double ballPct, double ballStruckPct)
        {
            _ballPct = ballPct;
            _ballStruckPct = ballStruckPct;

        }

        public PitchResults HandlePitch()
        {
            PitchResults toReturn = PitchResults.Strike;

            double randVal = r.NextDouble();

            if (randVal < _ballStruckPct)
            {
                double struckOutcomeRnd = r.NextDouble();

                if (struckOutcomeRnd < _hitPct)
                {

                    toReturn = PitchResults.Single;
                }
                else if (struckOutcomeRnd < _foulPct)
                {
                    toReturn = PitchResults.FoulBall;
                }
                else
                {
                    toReturn = PitchResults.GroundOut;
                }

            }
            else if (randVal < _ballStruckPct + _ballPct)
            {
                toReturn = PitchResults.Ball;
            }


            return toReturn;
        }

    }


    public class ResultProbabilities
        {
            public Double StrikeProb = 0.1;
            public Double BallProb = 0.1;
            public Double FoulBallProb = 0.1;
            public Double SingleProb = 0.1;
            public Double DoubleProb = 0.1;
            public Double TripleProb = 0.1;
            public Double HomeRunProb = 0.1;
            public Double GroundOutProb = 0.1;
        }


 
    }

