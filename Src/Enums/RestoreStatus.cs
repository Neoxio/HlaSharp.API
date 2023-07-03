namespace Neoxio.HlaSharp
{
    public enum RestoreStatus
    {
        NO_RESTORE_IN_PROGRESS,
        FEDERATE_RESTORE_REQUEST_PENDING,
        FEDERATE_WAITING_FOR_RESTORE_TO_BEGIN,
        FEDERATE_PREPARED_TO_RESTORE,
        FEDERATE_RESTORING,
        FEDERATE_WAITING_FOR_FEDERATION_TO_RESTORE
    }
}