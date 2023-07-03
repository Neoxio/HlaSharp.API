namespace Neoxio.HlaSharp
{
    public enum SaveFailureReason
    {
        RTI_UNABLE_TO_SAVE,
        FEDERATE_REPORTED_FAILURE_DURING_SAVE,
        FEDERATE_RESIGNED_DURING_SAVE,
        RTI_DETECTED_FAILURE_DURING_SAVE,
        SAVE_TIME_CANNOT_BE_HONORED,
        SAVE_ABORTED
    }
}