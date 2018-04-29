﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Exercise
    {
        private string _exerciseType; // Gồm Key, Word, Sentence, Paragraph

        //TODO : Thêm trường time vào file
        private int _time = 0;
        private string _name;
        private List<string> _exerciseText = new List<string>();

        public DTO_Exercise()
        {

        }

        public DTO_Exercise (string type, int time, string name, List<string> text)
        {
            this._exerciseType = type;
            this._time = time;
            this._name = name;
            this._exerciseText = text;
        }

        public string ExerciseType
        {
            get
            {
                return this._exerciseType;
            }
            set
            {
                this._exerciseType = value;
            }
        }

        public int Time
        {
            get
            {
                return this._time;
            }
            set
            {
                this._time = value;
            }
        }

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        public List<string> ExerciseText
        {
            get
            {
                return this._exerciseText;
            }
            set
            {
                this._exerciseText = value;
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
