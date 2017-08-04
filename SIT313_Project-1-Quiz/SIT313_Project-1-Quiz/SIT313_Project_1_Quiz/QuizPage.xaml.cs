using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

// Added library for serialising/deserialising JSON files.
using Newtonsoft.Json;
using System.Net.Http;

namespace SIT313_Project_1_Quiz
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuizPage : ContentPage
    {

        public QuizPage()
        {
            InitializeComponent();

            //Build the base layout.
            BuildQuizPage();
        }

        public void BuildQuizPage()
        {

            string test = "ID: ";

            string json = @"[
                {
                    ""id"": ""quiz01"",
                    ""title"": ""Mood Survey"",
                    ""questions"": [
                    {
                        ""id"": 1,
                        ""text"": ""Date"",
                        ""type"": ""date"",
                        ""help"": ""The date you started this quiz.""
                    },
                    {
                        ""id"": 2,
                        ""text"": ""Name"",
                        ""type"": ""textbox"",
                        ""help"": ""Your full name""
                    },
                    {
                        ""id"": 3,
                        ""text"": ""Diary"",
                        ""type"": ""textarea"",
                        ""help"": ""Write 4 paragraphs""
                    },
                    {
                        ""id"": 4,
                        ""text"": ""Gender"",
                        ""type"": ""choice"",
                        ""options"": [ ""Male"", ""Female"", ""Depends what day it is"" ]
                    }
                    ]
                },
                {
                    ""id"": ""quiz02"",
                    ""title"": ""Exam Grade"",
                    ""questionsPerPage"": [ 2, 4 ],
                    ""score"": 20,
                    ""questions"": [
                    {
                        ""id"": 1,
                        ""text"": ""Sid"",
                        ""type"": ""textbox"",
                        ""validate"": "" /[0-9]+/""
                    },
                    {
                        ""id"": 2,
                        ""text"": ""Name"",
                        ""type"": ""textbox"",
                        ""help"": ""Your full name""
                    },
                    {
                        ""id"": 3,
                        ""text"": ""What is the capital of Australia?"",
                        ""type"": ""textbox"",
                        ""answer"": ""Canberra"",
                        ""weighting"": 5
                    },
                    {
                        ""id"": 4,
                        ""text"": ""What is the largest state in Australia?"",
                        ""type"": ""textbox"",
                        ""answer"": [ ""Western Australia"", ""WA"" ],
                        ""weighting"": 5
                    },
                    {
                        ""id"": 5,
                        ""text"": ""What is the capital of Victoria?"",
                        ""type"": ""choice"",
                        ""options"": [ ""Sydney"", ""Brisbane"", ""Melbourne"" ],
                        ""answer"": ""Melbourne"",
                        ""weighting"": 5
                    }

                    ]
                }

                ]";

            List<RootQuiz> quizzes = JsonConvert.DeserializeObject<List<RootQuiz>>(json);

            foreach (RootQuiz q in quizzes)
            {
                test += q.ID.ToString();
            };

            //The header label.
            Label header = new Label
            {
                Text = test,
                TextColor = Color.FromHex("FFFFFF"), //Set text colour.
                FontAttributes = FontAttributes.Bold, //Set text attributes.
                FontSize = 25, //Set text font.
                BackgroundColor = Color.FromHex("000020"), //Set background colour
                HorizontalOptions = LayoutOptions.CenterAndExpand //Control placement.
            };

            //Combine and build base layout.
            this.Content = new StackLayout
            {
                BackgroundColor = Color.FromHex("000020"), //Set base background colour.
                Orientation = StackOrientation.Vertical, //Set base orientation.
                Children =
                {
                    header
                }
            };

        }

    }
}