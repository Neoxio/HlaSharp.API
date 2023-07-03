namespace Neoxio.HlaSharp
{
    public enum RestoreFailureReason
    {
        RTI_UNABLE_TO_RESTORE,
        FEDERATE_REPORTED_FAILURE_DURING_RESTORE,
        FEDERATE_RESIGNED_DURING_RESTORE,
        RTI_DETECTED_FAILURE_DURING_RESTORE,
        RESTORE_ABORTED
    }
}