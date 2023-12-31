﻿namespace curso_design_patterns.Behavorial.Command.Example02
{
    public class AddCommand : ICommand
    {
        private readonly double _valueToAdd;

        public AddCommand(double valueToAdd)
        {
            _valueToAdd = valueToAdd;
        }

        public double Execute(double value) =>
            value + _valueToAdd;

        public double Undo(double value) =>
            value - _valueToAdd;
    }
}
