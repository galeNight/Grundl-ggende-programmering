




namespace fodbold
{
    public class program
    {
        static void Main(string[] arges)
        {
            //local variable
            int score = 0;
            Console.WriteLine("fiffa");
            //infinite loop
            while (true)
            {

                // show score
                Console.WriteLine("score: " + score);
                //call position methode wich return an int
                int kickposs = pickposition();
                //call cepper metod wicht returns int
                int kepperpos = keeper();
                // call checkgoal wicht return true or false
                bool wasitagoal = checkgoal(kickposs, kepperpos);
                //add to score if ther is a goal
                if(wasitagoal)score++;
            }
        }
       static int pickposition()
        {
            Console.WriteLine("pick a prsition from 1 to 6");
            //readkey return the key char preesed
            char keypressed=Console.ReadKey().KeyChar;
            //check if char is a number
            if (char.IsDigit(keypressed))
            {
                //converts the char to and int
                int pos = (int)char.GetNumericValue(keypressed);
                //checks that number is betwring 1 and 6 and returns it from the methode was called
                if (pos <=6 && pos >=1 )return pos;
            }
            //else it return a -1 indicating the preesd a key ther was not a digit (miss)
            return -1;
            
        }
        static int keeper()
        {
            //creat a instanjst of an objest
            Random rand = new Random();
            int keeper=rand.Next(6)+1;
            return keeper;
        }
         static bool checkgoal(int kickpos,int kepperpos)
        {
            //keppers saveds
            if (kickpos == kepperpos)
            {
                Console.WriteLine("kepper saves");
                return false;
            }
            //player miss the goal
            else if (kickpos == -1)
            {
                Console.WriteLine("player miss the goal");
                return false;
            }
            //player scores a goal
            else
            {
                Console.WriteLine("player scores");
                return true;
            }
        }
    }
}
