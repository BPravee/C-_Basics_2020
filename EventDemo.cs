using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    public delegate void EventDistributor();
    public class Window
    {
        Button _clearButton = new Button();
        TextBox _searchTextBox = new TextBox();
        public Window()
        {
            //Subscribe for Button Click Event
            EventDistributor _handlerRef = new EventDistributor(this.OnClearButton_Click);
            this._clearButton.ClickEvent += _handlerRef;
          //  this._clearButton.Add_ClickEvent(_handlerRef);

            EventDistributor _newHandleRef = new EventDistributor(this.OnClearButtonNew_Click);
            //this._clearButton.Add_ClickEvent(_newHandleRef);
            this._clearButton.ClickEvent += _newHandleRef;
        }
        public void Show()
        {
            Console.WriteLine("window Painted");
        }
        public void SimulateClearButtonClick()
        {
            this._clearButton.OnClick();
        }
        //Event Handler / Subscriber
        void OnClearButton_Click()
        {
            this._searchTextBox.Clear();
        }
        void OnClearButtonNew_Click()
        {
            Console.WriteLine("Grid Content Cleared");
        }
    }
    public class Button
    {
        //Event - Delegate Instance
        //private <DelegateName> <EventName>
        public event  EventDistributor  ClickEvent=null;

        //Event Mutators
        //Subscribe
        //public void Add_ClickEvent(EventDistributor _hanlder)
        //{
        //    this.ClickEvent += _hanlder; //System.Delegate.Combine(this.ClickEvent,_handler)
        //}
        ////UnSubscribe
        //public void Remove_ClickEvent(EventDistributor _handler)
        //{
        //    //Remove Delegate Instance From Invocation List
        //    this.ClickEvent -= _handler;
        //}
        public void OnClick()
        {
            //Check for existance of at least one Subscriber
            if (this.ClickEvent != null)
            {
                //Raise An Event
                //Invoke Delegate Instance
                this.ClickEvent.Invoke();//iterate through Invocation List and Invoke All the delegate Intances
            }

        }

    }
    public class TextBox
    {
        public void Clear() { Console.WriteLine("TextBox Content Cleared"); }
    }
}

