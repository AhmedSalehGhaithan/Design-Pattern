namespace MediatorDesignPattern.ControlTowerProject
{
    public interface IControlTower
    {
        void RegisterRunway(Runway runway);
        bool RequestLandingPermission(Airplane airplane);
        void ReleaseRunway(Runway runway);
    }
}
