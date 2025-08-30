using activity_medic_appointment_api.Services;

namespace activity_medic_appointment_api.Business.Impl
{
    public class NotificacionImpl : INotificacion
    {
        private readonly ISendNotification sendNotification;

        public NotificacionImpl(ISendNotification sendNotification)
        {
            this.sendNotification = sendNotification;
        }
    }
}
