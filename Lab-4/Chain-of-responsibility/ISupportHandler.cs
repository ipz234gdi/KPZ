namespace ICSupportHandler
{
    public interface ISupportHandler
    {
        void SetNext(ISupportHandler nextHandler);
        bool Handle(string issue);
    }
}