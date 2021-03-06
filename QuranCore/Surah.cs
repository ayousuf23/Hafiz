﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuranCore
{
    
    public class Surah : SurahBase
    {
        public IDictionary<int, Ayat> Ayaat { get; set; }

        public Surah()
        {
            Ayaat = new Dictionary<int, Ayat>();
        }

        public Surah(int index, string en_name, string ar_name, bool bismillah, string juz)
        {
            Index = index;
            EN_Name = en_name;
            AR_Name = ar_name;
            Bismillah = bismillah;
            Juz = juz;
        }

        public Surah(int index, string en_name, string ar_name, bool bismillah, string juz, IDictionary<int, Ayat> ayaat) : this(index, en_name, ar_name, bismillah, juz)
        {
            Ayaat = new Dictionary<int, Ayat>(ayaat);
        }

        public SerializableSurah ConvertToSerializable()
        {
            SerializableSurah s = new SerializableSurah(Index, EN_Name, AR_Name, Bismillah, Juz);
            s.Ayaat = Ayaat.Values.ToArray();
            return s;
        }

        public Surah Clone(QuranType type)
        {
            if (type == QuranType.Concurrent)
            {
                return new ConcurrentSurah(Index, EN_Name, AR_Name, Bismillah, Juz, Ayaat);
            }
            return new Surah(Index, EN_Name, AR_Name, Bismillah, Juz, Ayaat);
        }

        public ArrangeSurah ConvertToArrange()
        {
            ArrangeSurah surah = new ArrangeSurah(Index, EN_Name, AR_Name, Bismillah, Juz);
            surah.Ayaat = Ayaat.Values.ToArray();
            return surah;
        }

        public ArrangeSurah ConvertToArrange(int begin, int end)
        {
            if (begin < 1 || end > Ayaat.Count || begin > end)
            {
                return null;
            }
            ArrangeSurah surah = new ArrangeSurah(Index, EN_Name, AR_Name, Bismillah, Juz);
            surah.Ayaat = new Ayat[end - begin + 1];
            int j = 0;
            for (int i=begin; i<=end; i++)
            {
                surah.Ayaat[j] = Ayaat[i].Clone();
                j++;
            }
            return surah;
        }

        public Quiz GenerateQuiz(Random random)
        {
            Quiz quiz = new Quiz(Index, EN_Name);

            int COUNT = (5 < Ayaat.Count) ? 5 : Ayaat.Count - 1;
            int CHOICES_PER_QUESTION = (4 < Ayaat.Count) ? 4 : Ayaat.Count - 1;

            //Indexes for ayaat
            HashSet<int> indices = new HashSet<int>();
            HashSet<int> usedChoiceIndex = new HashSet<int>();
            HashSet<int> scrambledIndices = new HashSet<int>();


            quiz.Questions = new QuizQuestion[COUNT];


            for (int i=0; i<COUNT; i++)
            {
                //Index for ayat
                int index = random.Next(1, Ayaat.Count);
                while(Ayaat[index].Repeated || !indices.Add(index))
                {
                    index = random.Next(1, Ayaat.Count);
                }

                quiz.Questions[i] = new QuizQuestion();
                quiz.Questions[i].Text = Ayaat[index].Text;

                quiz.Questions[i].Choices = new string[CHOICES_PER_QUESTION];

               
                //Add index of question ayat
                usedChoiceIndex.Add(index);
                //Add index of ayat after the selected question ayat
                usedChoiceIndex.Add(++index);        
                
                int scrambledIndex = random.Next(0, CHOICES_PER_QUESTION);
                quiz.Questions[i].Choices[scrambledIndex] = Ayaat[index].Text;
                quiz.Questions[i].CorrectChoice = scrambledIndex;
                bool isRepeating = Ayaat[index].Repeated;
                scrambledIndices.Add(scrambledIndex);
                
                while (scrambledIndices.Count < CHOICES_PER_QUESTION)
                {
                    index = random.Next(1, Ayaat.Count + 1);
                    while ((isRepeating && Ayaat[index].Repeated) || !usedChoiceIndex.Add(index))
                    {
                        index = random.Next(1, Ayaat.Count + 1);
                    }

                    while(!scrambledIndices.Add(scrambledIndex = random.Next(0, CHOICES_PER_QUESTION)))
                    {

                    }

                    quiz.Questions[i].Choices[scrambledIndex] = Ayaat[index].Text;
                }

                if (i != COUNT - 1)
                {
                    usedChoiceIndex.Clear();
                    scrambledIndices.Clear();
                }
            }

            return quiz;
        }

        public Quiz GenerateFillInTheBlanksQuiz(ref Random random)
        {
            Quiz quiz = new Quiz(Index, EN_Name);

            int COUNT = (5 < Ayaat.Count) ? 5 : Ayaat.Count - 1;

            //Indexes for ayaat
            HashSet<int> indices = new HashSet<int>();


            quiz.Questions = new QuizQuestion[COUNT];

            for (int i = 0; i < COUNT; i++)
            {
                //Index for ayat
                int index = random.Next(1, Ayaat.Count);
                while (Ayaat[index].Repeated || !indices.Add(index))
                {
                    index = random.Next(1, Ayaat.Count);
                }

                quiz.Questions[i] = new QuizQuestion();


                Ayaat[index].MakeFillInTheBlankQestion(ref quiz.Questions[i], ref random);
            }

            return quiz;
        }

    }

    public class ConcurrentSurah : Surah
    {
        public ConcurrentSurah()
        {
            Ayaat = new System.Collections.Concurrent.ConcurrentDictionary<int, Ayat>();
        }

        public ConcurrentSurah(int index, string en_name, string ar_name, bool bismillah, string juz, IDictionary<int, Ayat> ayaat)
            : base(index, en_name, ar_name, bismillah, juz)
        {
            Ayaat = new System.Collections.Concurrent.ConcurrentDictionary<int, Ayat>(ayaat);
        }
    }
}
