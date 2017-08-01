using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SIT313_Project_1_Quiz
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //Dynamically build the layout for the 'login' page.
            BuildLoginPage();
        }

        public void BuildLoginPage()
        {

            /*
             *  The follwing codes are referenced from these URLs.
             *  Base URL: {https://developer.xamarin.com/guides/xamarin-forms/user-interface/controls/layouts/}
             *  Specific Layout URL: {https://developer.xamarin.com/api/type/Xamarin.Forms.StackLayout/}
             *  
             *  It shows some examples of how to dynamically build a layout from the .cs file.
             */

            //The header label.
            Label header = new Label
            {
                //Set the text and its colour.
                Text = "SIT313 Quiz!",
                TextColor = Color.FromHex("FFFFFF"), //Color codes are taken from this URL: {http://htmlcolorcodes.com/}

                //Set the text's font size and current attribute (e.g. Bold, Italic, etc).
                FontAttributes = FontAttributes.Bold,
                FontSize = 50,

                //Set and appropriate background colour.
                BackgroundColor = Color.FromHex("000020"),

                //Set where this object will 'fit' in the page.
                HorizontalOptions = LayoutOptions.CenterAndExpand //Controls horizontal placement. Vertical placement: 'VerticalOptions'.
            };

            //The StackLayout containing the body contents for the page.
            StackLayout layout_content = new StackLayout
            {

                Spacing = 3, //Assign appropriate spacing.
                Orientation = StackOrientation.Vertical, //Set orientation to vertical (Display from top to bottom).
                VerticalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.FromHex("e6fcff"), //Set background colour.
                Padding = new Thickness(7, 13, 7, 0), //Set the padding for a better style

                //The UI elements within this layout.
                Children =
                {

                    //Display the appropriate labels and textfields for specific input.
                    //The following is for the 'Username' field.
                    new StackLayout
                    {
                        Spacing = 1,
                        Orientation = StackOrientation.Horizontal, //Set orientation to vertical (Display from left to right).
                        Children = {
                            new Label
                            {
                                Text = "Username:",
                                HorizontalOptions = LayoutOptions.Start,
                                VerticalOptions = LayoutOptions.Center
                            },
                            new Entry {
                                Placeholder = "Username",
                                HorizontalOptions = LayoutOptions.FillAndExpand,
                            }
                        }
                    },

                    //The following is for the 'Password' field.
                    new StackLayout
                    {
                        Spacing = 2,
                        Orientation = StackOrientation.Horizontal,
                        Children = {
                            new Label
                            {
                                Text = "Password:",
                                HorizontalOptions = LayoutOptions.Start,
                                VerticalOptions = LayoutOptions.Center
                            },
                            new Entry {
                                Placeholder = "Password",
                                IsPassword = true, //Set block characters to hide passwords.
                                HorizontalOptions = LayoutOptions.FillAndExpand
                            }
                        }
                    },

                    //The 'Login' Button
                    new Button
                    {
                        Text = "Login",
                        TextColor = Color.FromHex("FFFFFF"),
                        //Set the prefered size for the button
                        HeightRequest = 40,
                        WidthRequest = 150,
                        BackgroundColor = Color.FromHex("000f3c"),
                        HorizontalOptions = LayoutOptions.Center
                    },

                    //The 'Register' Button
                    new Button
                    {
                        Text = "Register",
                        TextColor = Color.FromHex("FFFFFF"),
                        //Set the prefered size for the button
                        HeightRequest = 40,
                        WidthRequest = 150,
                        BackgroundColor = Color.FromHex("000f3c"),
                        HorizontalOptions = LayoutOptions.Center
                    },

                    //The 'Guest' Button (For guests; no persistent data)
                    new Button
                    {
                        Text = "Guest",
                        TextColor = Color.FromHex("FFFFFF"),
                        //Set the prefered size for the button
                        HeightRequest = 40,
                        WidthRequest = 150,
                        BackgroundColor = Color.FromHex("000f3c"),
                        HorizontalOptions = LayoutOptions.Center
                    }

                }

            };

            //Combine all components for the final layout.
            //URL: {https://github.com/xamarin/xamarin-forms-samples/blob/master/FormsGallery/FormsGallery/FormsGallery/StackLayoutDemoPage.cs}
            this.Content = new StackLayout
            {
                BackgroundColor = Color.FromHex("000020"),
                Children =
                {
                    header,
                    layout_content
                }
            };
            
        }


    }
}
