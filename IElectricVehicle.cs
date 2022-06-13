namespace Generics
{
    public interface IElectricVehicle
    {
        double CurrentChargePercentage { get; }
        void ChargeBattery();
    }
}