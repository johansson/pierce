using System;

namespace Pierce.Example.Views
{
    public interface IDateTimeView : IView
    {
        void SetValue(DateTime value);
    }
}

