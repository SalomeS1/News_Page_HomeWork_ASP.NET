using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Views.Home;

namespace Test.Models
{
    public static class NewsVM
    {

        public static List<News> data = new List<News>()
        {
            new News()
            {
                ID = 1,
                Info = new List<NewsLang>(){
                    { new NewsLang(){
                        Title = "What is Lorem Ipsum?",
                        Desription = "Lorem Ipsum is simply dummy text of the printing and " +
                        "typesetting industry. Lorem Ipsum has been the industry's standard " +
                        "dummy text ever since the 1500s, when an unknown printer took a galley of type ",
                         Lang = "en" } },
                    { new NewsLang(){
                        Title = "ქართული Lorem Ipsum?",
                        Desription = "ქართული ტექსტით " +
                        "typesetting industry. Lorem Ipsum has been the industry's standard " +
                        "dummy text ever since the 1500s, when an unknown printer took a galley of type ",
                        Lang = "ka"  } }
                },
                Thumb = "1.jpg",
                Slag = "first-news"
            },

             new News()
            {
                ID = 2,
                Info = new List<NewsLang>(){
                    { new NewsLang(){
                        Title = "Why do we use it?",
                        Desription =  "Lorem Ipsum is simply dummy text of the printing and " +
                        "typesetting industry. Lorem Ipsum has been the industry's standard " +
                        "dummy text ever since the 1500s, when an unknown printer took a galley of type ",
                        Lang = "en" } },
                    {new NewsLang(){
                        Title = "ქართული სათაური?",
                        Desription =  "ქართული ტექსტით " +
                        "typesetting industry. Lorem Ipsum has been the industry's standard " +
                        "dummy text ever since the 1500s, when an unknown printer took a galley of type ",
                        Lang = "ka" } }
                },
                Thumb = "2.jpg",
                Slag = "second-news"
            },

             new News()
            {
                ID = 3,
                Info = new List<NewsLang>(){
                    {new NewsLang(){
                            Title = "Where does it come from?",
                            Desription =  "Lorem Ipsum is simply dummy text of the printing and " +
                            "typesetting industry. Lorem Ipsum has been the industry's standard " +
                            "dummy text ever since the 1500s, when an unknown printer took a galley of type ",
                            Lang = "en" } },
                    {new NewsLang(){
                            Title = "ქართული სათაური?",
                            Desription =  "ქართული ტექსტით " +
                            "typesetting industry. Lorem Ipsum has been the industry's standard " +
                            "dummy text ever since the 1500s, when an unknown printer took a galley of type ",
                            Lang = "ka" } }
                },
                Thumb = "3.jpg",
                Slag = "third-news"
            }
        };
    }
}
