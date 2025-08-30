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

        private void Send(string message, int userId)
        {
            switch (NotificationRegister(message, userId))
            {
                case 1:
                    sendNotification.SendEmail();
                    break;
                default:

                    break;
            }
            
        }

        private int NotificationRegister(string message, int userId)
        {
            return 1;
        }
    }
}
