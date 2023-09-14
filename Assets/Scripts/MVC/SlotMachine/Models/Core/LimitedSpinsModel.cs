﻿using MVC.SlotMachine.Views.Core;

namespace MVC.SlotMachine.Models.Core
{
    public class LimitedSpinsModel : Model
    {
        private readonly int _maxSpins;

        public LimitedSpinsModel(View view, int maxSpins) : base(view)
        {
            _maxSpins = maxSpins;
        }

        public override bool CanSpin() => SpinsCount < _maxSpins;
    }
}
