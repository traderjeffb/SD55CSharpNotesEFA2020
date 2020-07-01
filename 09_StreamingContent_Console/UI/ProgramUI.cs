using _07_RepositoryPattern_.Repository;
using _08_StreamingContent_Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _09_StreamingContent_Console.UI
{
    public class ProgramUI
    {
        private readonly StreamingRepository _streamingReop = new StreamingRepository();
        public void Run()
        {
            RunMenu();
        }
        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {

                Console.WriteLine(
                    "Enter the number of the option you'd like to select: \n" +
                    "1. Show all streaming content \n" +
                    "2. Find streaming content by title \n" +
                    "3. Add new streaming content \n" +
                    "4. Remove streaming content \n" +
                    "5. Exit");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        //show all
                        break;
                    case "2":
                        //find by title
                        break;
                    case "3":
                        //add new
                        CreateNewContent();
                        break;
                    case "4":
                        //remove
                        break;
                    case "5":
                        //exit
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number between 1-5. \n" +
                            "Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
        }
        private void CreateNewContent()
        {
            Console.Clear();
            StreamingContent content = new StreamingContent();
            //title
            Console.Clear();
            Console.WriteLine("Please enter the title of the content:");
            content.Title = Console.ReadLine();
            //description
            Console.WriteLine("please enter a discription:");
            //MRating
            Console.WriteLine("Select a Maturity rating: \n" +
                "1) G \n" +
                "2) PG \n" +
                "3)PG 13 \n" +
                "4)R \n" +
                "5)NC 17 \n" +
                "6) TV MA \n");
            string maturityRating = Console.ReadLine();
            switch (maturityRating)
            {
                case "1":
                    content.MaturityRating = MaturityRating.G;
                    break;
                case "2":
                    content.MaturityRating = MaturityRating.PG;
                    break;
                case "3":
                    content.MaturityRating = MaturityRating.PG_13;
                    break;
                case "4":
                    content.MaturityRating = MaturityRating.R;
                    break;
                case "5":
                    content.MaturityRating = MaturityRating.NC_17;
                    break;

                case "6":
                    content.MaturityRating = MaturityRating.TV_MA;
                    break;
            }
            //star rating
            Console.WriteLine(" Please enter the star rating 1-5: ");
            content.StarRating = int.Parse(Console.ReadLine());
            //type of genre
            Console.WriteLine("Select a Genre: \n" +
            "1. Horror \n" +
            "2 sci-fi \n" +
            "3 drama \n" +
            "4  action \n" +
            "5 Comedy \n" +
            "6 Anime \n" +
            "7 documentary \n" +
            "8 thriller \n" +
            "9 romance \n");
            string genreInput = Console.ReadLine();
            int genreID = int.Parse(genreInput);
            content.TypeOfGenre = (GenreType)genreID; //casting
            _streamingReop.AddContentToDirectory(content);



        }
        private void ShowAllContent()
        {
            Console.Clear();
            List<StreamingContent> listOfContent = _streamingReop.GetContents();
            foreach(StreamingContent contentVariable in listOfContent)
            {
                Console.WriteLine($"{contentVariable.Title} {contentVariable.Description}");
            }
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
        }

        private void DisplayContent(StreamingContent content
            )
    }
}
