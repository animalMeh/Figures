namespace Figures.Model
{
    public interface IIntersectable
    {
        int X { get; }
        int Y { get; }

        int Height { get; }
        int Width { get; }

        bool IsIntersect(IIntersectable obj);
    }
}
