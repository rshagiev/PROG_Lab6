namespace lab6
{
    public interface IController
    {
        void SetModel(IModel m);
        void SetView(IView v);
        void Add(int el);//for add button
        void RemoveSelected();//for delete button
        void RemoveMax();//for extract button
        void RemoveMin();
        void ClaerAll();
    }
}
