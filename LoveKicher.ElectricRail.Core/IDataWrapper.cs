namespace LoveKicher.ElectricRail.Core
{
    public interface IDataWrapper<TData, TWrapped>
    {
        TWrapped WrappedData { get; }
        string WrapperType { get; }

        TData Unwarp();
        void Wrap(TData data);
    }
}