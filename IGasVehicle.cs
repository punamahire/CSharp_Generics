namespace Generics
{
    public interface IGasVehicle
    {
        double CurrentTankPercentage { get; }
        void RefuelTank();
    }
}