﻿using L052_Labb3_Code_along.Model;
using System.Collections.ObjectModel;

namespace L052_Labb3_Code_along.ViewModel
{
    internal class QuestionPackViewModel : ViewModelBase
    {
        private readonly QuestionPack _model;


        public string Name
        {
            get => _model.Name;
            set
            {
                _model.Name = value;
                RaiseProperyChanged();
            }
        }

        public Difficulty Difficulty
        {
            get => _model.Difficulty;
            set
            {
                _model.Difficulty = value;
                RaiseProperyChanged();
            }
        }

        public int TimeLimitInSeconds
        {
            get => _model.TimeLimitInSeconds;
            set
            {
                _model.TimeLimitInSeconds = value;
                RaiseProperyChanged();
            }
        }

        public ObservableCollection<Question> Questions { get; }




        public QuestionPackViewModel(QuestionPack model)
        {
            this._model = model;
            this.Questions = new ObservableCollection<Question>(model.Questions);
        }

    }
}
