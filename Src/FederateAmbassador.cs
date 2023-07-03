using System.Collections.Generic;
using Neoxio.HlaSharp.Handles;
using Neoxio.HlaSharp.Interop;
using Neoxio.HlaSharp.Time;

namespace Neoxio.HlaSharp
{
    public abstract class FederateAmbassador : UnmanagedHlaObject
    {
        public FederateAmbassador()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }


        protected override void Dispose(bool disposing)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void ConnectionLost(string faultDescription)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void ReportFederationExecutions(List<FederationExecutionInformation> theFederationExecutionInformationList)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void SynchronizationPointRegistrationSucceeded(string label)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void SynchronizationPointRegistrationFailed(string label, SynchronizationPointFailureReason reason)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void AnnounceSynchronizationPoint(string label, VariableLengthData theUserSuppliedTag)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void FederationSynchronized(string label, List<FederateHandle> failedToSyncSet)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void InitiateFederateSave(string label)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void InitiateFederateSave(string label, LogicalTime theTime)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void FederationSaved()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void FederationNotSaved(SaveFailureReason theSaveFailureReason)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void FederationSaveStatusResponse(List<FederateSaveStatus> theFederateStatusVector)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void RequestFederationRestoreSucceeded(string label)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void RequestFederationRestoreFailed(string label)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void FederationRestoreBegun()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void InitiateFederateRestore(string label, string federateName, FederateHandle handle)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void FederationRestored()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void FederationNotRestored(RestoreFailureReason theRestoreFailureReason)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void FederationRestoreStatusResponse(List<FederateRestoreStatus> theFederateRestoreStatusVector)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void StartRegistrationForObjectClass(ObjectClassHandle theClass)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void StopRegistrationForObjectClass(ObjectClassHandle theClass)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void TurnInteractionsOn(InteractionClassHandle theHandle)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void TurnInteractionsOff(InteractionClassHandle theHandle)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void ObjectInstanceNameReservationSucceeded(string theObjectInstanceName)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void ObjectInstanceNameReservationFailed(string theObjectInstanceName)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void MultipleObjectInstanceNameReservationSucceeded(string[] theObjectInstanceNames)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void MultipleObjectInstanceNameReservationFailed(string[] theObjectInstanceNames)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void DiscoverObjectInstance(ObjectInstanceHandle theObject, ObjectClassHandle theObjectClass, string theObjectInstanceName)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void DiscoverObjectInstance(ObjectInstanceHandle theObject, ObjectClassHandle theObjectClass, string theObjectInstanceName, FederateHandle producingFederate)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void ReflectAttributeValues(ObjectInstanceHandle theObject, IDictionary<AttributeHandle, VariableLengthData> theAttributeValues, VariableLengthData theUserSuppliedTag, OrderType sentOrder, TransportationType theType, SupplementalReflectInfo theReflectInfo)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void ReflectAttributeValues(ObjectInstanceHandle theObject, IDictionary<AttributeHandle, VariableLengthData> theAttributeValues, VariableLengthData theUserSuppliedTag, OrderType sentOrder, TransportationType theType, LogicalTime theTime, OrderType receivedOrder, SupplementalReflectInfo theReflectInfo)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void ReflectAttributeValues(ObjectInstanceHandle theObject, IDictionary<AttributeHandle, VariableLengthData> theAttributeValues, VariableLengthData theUserSuppliedTag, OrderType sentOrder, TransportationType theType, LogicalTime theTime, OrderType receivedOrder, MessageRetractionHandle theHandle, SupplementalReflectInfo theReflectInfo)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void ReceiveInteraction(InteractionClassHandle theInteraction, IDictionary<ParameterHandle, VariableLengthData> theParameterValues, VariableLengthData theUserSuppliedTag, OrderType sentOrder, TransportationType theType, SupplementalReceiveInfo theReceiveInfo)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void ReceiveInteraction(InteractionClassHandle theInteraction, IDictionary<ParameterHandle, VariableLengthData> theParameterValues, VariableLengthData theUserSuppliedTag, OrderType sentOrder, TransportationType theType, LogicalTime theTime, OrderType receivedOrder, SupplementalReceiveInfo theReceiveInfo)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void ReceiveInteraction(InteractionClassHandle theInteraction, IDictionary<ParameterHandle, VariableLengthData> theParameterValues, VariableLengthData theUserSuppliedTag, OrderType sentOrder, TransportationType theType, LogicalTime theTime, OrderType receivedOrder, MessageRetractionHandle theHandle, SupplementalReceiveInfo theReceiveInfo)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void RemoveObjectInstance(ObjectInstanceHandle theObject, VariableLengthData theUserSuppliedTag, OrderType sentOrder, SupplementalRemoveInfo theRemoveInfo)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void RemoveObjectInstance(ObjectInstanceHandle theObject, VariableLengthData theUserSuppliedTag, OrderType sentOrder, LogicalTime theTime, OrderType receivedOrder, SupplementalRemoveInfo theRemoveInfo)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void RemoveObjectInstance(ObjectInstanceHandle theObject, VariableLengthData theUserSuppliedTag, OrderType sentOrder, LogicalTime theTime, OrderType receivedOrder, MessageRetractionHandle theHandle, SupplementalRemoveInfo theRemoveInfo)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void AttributesInScope(ObjectInstanceHandle theObject, List<AttributeHandle> theAttributes)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void AttributesOutOfScope(ObjectInstanceHandle theObject, List<AttributeHandle> theAttributes)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void ProvideAttributeValueUpdate(ObjectInstanceHandle theObject, List<AttributeHandle> theAttributes, VariableLengthData theUserSuppliedTag)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void TurnUpdatesOnForObjectInstance(ObjectInstanceHandle theObject, List<AttributeHandle> theAttributes)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void TurnUpdatesOnForObjectInstance(ObjectInstanceHandle theObject, List<AttributeHandle> theAttributes, string updateRateDesignator)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void TurnUpdatesOffForObjectInstance(ObjectInstanceHandle theObject, List<AttributeHandle> theAttributes)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void ConfirmAttributeTransportationTypeChange(ObjectInstanceHandle theObject, List<AttributeHandle> theAttributes, TransportationType theTransportation)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void ReportAttributeTransportationType(ObjectInstanceHandle theObject, AttributeHandle theAttribute, TransportationType theTransportation)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void ConfirmInteractionTransportationTypeChange(InteractionClassHandle theInteraction, TransportationType theTransportation)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void ReportInteractionTransportationType(FederateHandle federateHandle, InteractionClassHandle theInteraction, TransportationType theTransportation)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void RequestAttributeOwnershipAssumption(ObjectInstanceHandle theObject, List<AttributeHandle> offeredAttributes, VariableLengthData theUserSuppliedTag)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void RequestDivestitureConfirmation(ObjectInstanceHandle theObject, List<AttributeHandle> releasedAttributes)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void AttributeOwnershipAcquisitionNotification(ObjectInstanceHandle theObject, List<AttributeHandle> securedAttributes, VariableLengthData theUserSuppliedTag)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void AttributeOwnershipUnavailable(ObjectInstanceHandle theObject, List<AttributeHandle> theAttributes)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void RequestAttributeOwnershipRelease(ObjectInstanceHandle theObject, List<AttributeHandle> candidateAttributes, VariableLengthData theUserSuppliedTag)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void ConfirmAttributeOwnershipAcquisitionCancellation(ObjectInstanceHandle theObject, List<AttributeHandle> theAttributes)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void InformAttributeOwnership(ObjectInstanceHandle theObject, AttributeHandle theAttribute, FederateHandle theOwner)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void AttributeIsNotOwned(ObjectInstanceHandle theObject, AttributeHandle theAttribute)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void AttributeIsOwnedByRTI(ObjectInstanceHandle theObject, AttributeHandle theAttribute)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void TimeRegulationEnabled(LogicalTime theFederateTime)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void TimeConstrainedEnabled(LogicalTime theFederateTime)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void TimeAdvanceGrant(LogicalTime theTime)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void RequestRetraction(MessageRetractionHandle theHandle)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }
    }
}