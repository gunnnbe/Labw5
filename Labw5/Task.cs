using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labw5
{
    internal class Task
    {
    }
}
public class Task : INotifyPropertyChanged
{
    private string title;
    private string description;
    private DateTime deadline;

    public string Title
    {
        get { return title; }
        set
        {
            title = value;
            OnPropertyChanged(nameof(Title));
        }
    }

    public string Description
    {
        get { return description; }
        set
        {
            description = value;
            OnPropertyChanged(nameof(Description));
        }
    }

    public DateTime Deadline
    {
        get { return deadline; }
        set
        {
            deadline = value;
            OnPropertyChanged(nameof(Deadline));
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
