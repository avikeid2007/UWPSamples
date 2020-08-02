using DataAccessLayer.Models;
using System;
using System.Collections.Generic;

namespace DataAccessLayer.DummyDataService
{
    public static class DummyData
    {
        public static List<Post> GetDummyData()
        {
            return new List<Post>
            {
                new Post
                {
                    Id = 1,
                    AuthorName = "Moana Bauer",
                    PublishDate=new DateTime(2020, 5, 11, 0, 0, 0, DateTimeKind.Utc),
                    Title = "18 ways living room ideas can make you rich",
                    Picture="http://2.bp.blogspot.com/-bL055xgm-20/VffFwULUnyI/AAAAAAAANrQ/DOgYrjPnzd8/s1600/design_on-light-wheels_142K.jpg",
                    Content = @"18 great articles about modern homes. The oddest place you will find living room decors. 5 bs facts about home builders everyone thinks are true. 12 things you don't want to hear about luxury homes. An expert interview about living room decors. 19 least favorite kitchen designs. 9 things about rent houses your kids don't want you to know. How hollywood got living room decors all wrong. How twitter can teach you about kitchen designs. What the beatles could learn from small house plans. The oddest place you will find designer furniture. 5 ideas you can steal from kitchen designs. What wikipedia can't tell you about interior designs. Modern living rooms by the numbers. Ways your mother lied to you about architects. The complete beginner's guide to home builders. How modular homes are making the world a better place. Why interior design jobs are on crack about interior design jobs. The unconventional guide to architects. 16 insane (but true) things about modern homes."
                },
                 new Post
                {
                    Id = 2,
                    AuthorName = "MacKenzie Langley",
                    PublishDate=new DateTime(2020, 6, 21, 0, 0, 0, DateTimeKind.Utc),
                    Title = "13 ways cool tech gadgets could leave you needing a lawyer",
                    Picture="http://4.bp.blogspot.com/-uX6aV9khr84/VffTRGn1HmI/AAAAAAAAOs8/4iaLwMcj0ZA/s1600/technology_android-user-with-coffee_043K.jpg",
                    Content = @"Why the world would end without devices. 13 great articles about open source software. 11 least favorite passport applications. The 10 worst songs about future technologies. An expert interview about business software. 13 secrets about computer support specialists the government is hiding. Why open source software will make you question everything. How storage devices changed how we think about death. 18 problems with life technologies. How cool tech gadgets aren't as bad as you think.
The complete beginner's guide to passport applications. Why our world would end if new inventions disappeared. How to be unpopular in the accessory world. How wholesale accessories can help you live a better life. The 12 best dollar general application youtube videos. Why our world would end if cool tech gadgets disappeared. The evolution of business software. 19 uses for business software. Why you shouldn't eat open source software in bed. 15 things that won't happen in tech reviews."
                 },
                 new Post
                {
                    Id = 3,
                    AuthorName = "Suki Reilly",
                    PublishDate=new DateTime(2020, 6, 21, 0, 0, 0, DateTimeKind.Utc),
                    Title = "Why the next 10 years of homemade beauty products will smash the last 10",
                    Picture="http://4.bp.blogspot.com/-sjwCSOtitzM/VffNQ4OSDgI/AAAAAAAAOOU/fTcVl5UOEDY/s1600/life_found-a-new-happiness_194K.jpg",
                    Content = @"11 amazing lifestyle blog pictures. 6 uses for money saving tips. 15 ways love tests are completely overrated. Ways your mother lied to you about celebrity gossip pictures. Unbelievable beauty essential success stories. Unbelievable money saving tips success stories. Why budget calculators should be 1 of the 7 deadly sins. 5 ways celebrity photos could leave you needing a lawyer. How hollywood got makeup brushes all wrong. What the beatles could learn from wedding invitations.

Lifestyle blogs by the numbers. An expert interview about homemade beauty products. Why mom was right about makeup brushes. 19 great articles about individual sport. What the world would be like if love tests didn't exist. Why celebrity gossip pictures will change your life. 10 ideas you can steal from celebrity houses. If you read one article about lifestyle markets read this one. Why inspirational quotes will make you question everything. The best ways to utilize individual development plans."
                 },
                 new Post
                {
                    Id = 4,
                    AuthorName = "Hedy Fuller",
                    PublishDate=new DateTime(2020, 6, 21, 0, 0, 0, DateTimeKind.Utc),
                    Title = "Why road trip games beat peanut butter on pancakes",
                    Picture="http://2.bp.blogspot.com/-ALRTUnRCWRI/VffVeOiKx4I/AAAAAAAAO6A/V2BR0JpiMnE/s1600/travel_lost-memory-of-childhood_174K.jpg",
                    Content = @"What the world would be like if summer activities didn't exist. Why daily deals will change your life. If you read one article about trip ideas read this one. Why the next 10 years of choice hotels will smash the last 10. Why travel insurances should be 1 of the 7 deadly sins. The 14 worst songs about travel agencies. Why travel agents will change your life. The 19 worst songs about family trip ideas. How twitter can teach you about travel packages. How travel insurances changed how we think about death.

How choice hotels can help you predict the future. Honeymoon packages in 14 easy steps. 18 facts about travel packages that will impress your friends. Why travel advisors beat peanut butter on pancakes. How travel agencies changed how we think about death. How celebrity cruises are making the world a better place. 20 facts about cheapest flights that'll keep you up at night. 6 myths uncovered about travel agencies. 9 ways travel insurances can make you rich. Why your flight scanner never works out the way you plan."
                 },
                 new Post
                {
                    Id = 5,
                    AuthorName = "Howard Norton",
                    PublishDate=new DateTime(2020, 6, 21, 0, 0, 0, DateTimeKind.Utc),
                    Title = "Why auto repair shops are killing you",
                    Picture="http://2.bp.blogspot.com/-psDcKMDYryc/VfehR9iGjQI/AAAAAAAANb0/El1ZTyaNZjA/s1600/automotive_bmw-race_117K.jpg",
                    Content = @"Why you'll never succeed at auto paint shops. Why the next 10 years of windshield repairs will smash the last 10. 12 things about automotive technicians your kids don't want you to know. How twitter can teach you about supercar prices. The 12 best resources for automotive museums. 12 things you don't want to hear about car companies. Will auto parts ever rule the world? What the world would be like if automotive museums didn't exist. 8 things your boss expects you know about auto glass. 20 things about automotive tires your kids don't want you to know.

5 movies with unbelievable scenes about car seat covers. The best ways to utilize auto parts. 10 uses for automotive jobs. Why mom was right about car parts. The 12 worst automotive technicians in history. How twitter can teach you about auto repair shops. If you read one article about auto body parts read this one. 16 secrets about hybrid supercars the government is hiding. 12 ideas you can steal from auto parts stores. The 8 worst songs about discount auto parts."
                 },
                 new Post
                {
                    Id = 6,
                    AuthorName = "Kennan Glover",
                    PublishDate=new DateTime(2020, 6, 21, 0, 0, 0, DateTimeKind.Utc),
                    Title = "Why mom was right about famous entrepreneurs",
                    Picture="http://3.bp.blogspot.com/-gnG_EbtPvxw/VfejU1Gy8mI/AAAAAAAANjc/u8LGVFooTKw/s1600/business_job-interview-best-candidate_277K.jpg",
                    Content = @"Why financial advisors are killing you. Why you shouldn't eat good interview question in bed. How stock quotes can make you sick. Unbelievable stock quote success stories. Why business reviews will make you question everything. What everyone is saying about famous entrepreneurs. Why your business review never works out the way you plan. Why you'll never succeed at small business loans. The oddest place you will find startup opportunities. Expose: you're losing money by not using business analysts.

Why interview techniques are killing you. 14 ideas you can steal from personal finances. Why mom was right about stock brokers. Why business administrations should be 1 of the 7 deadly sins. The oddest place you will find insurance companies. The 12 worst franchises in history. The 16 worst songs about startup opportunities. 8 ways business insurances could leave you needing a lawyer. How business managers made me a better person. Investors by the numbers."
                 },

            };
        }
    }
}
