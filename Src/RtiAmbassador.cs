using System.Collections.Generic;
using Neoxio.HlaSharp.Handles;
using Neoxio.HlaSharp.Interop;
using Neoxio.HlaSharp.Time;

namespace Neoxio.HlaSharp
{
    public class RtiAmbassador : UnmanagedHlaObject
    {
        public void Connect(FederateAmbassador federateAmbassador, CallbackModel theCallbackModel, string localSettingsDesignator)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void Disconnect()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void CreateFederationExecution(string federationExecutionName, string fomModule, string logicalTimeImplementationName)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void CreateFederationExecution(string federationExecutionName, string[] fomModules, string logicalTimeImplementationName)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void CreateFederationExecutionWithMIM(string federationExecutionName, string[] fomModules, string mimModule, string logicalTimeImplementationName)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void DestroyFederationExecution(string federationExecutionName)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void ListFederationExecutions()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void JoinFederationExecution(string federateType, string fedExecutionName, string[] additionalFomModules, bool useGenericTime = false)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void JoinFederationExecution(string federateType, string fedExecutionName, string[] additionalFomModules, out FederateHandle handle, bool useGenericTime = false)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void JoinFederationExecution(string federateName, string federateType, string fedExecutionName, string[] additionalFomModules, bool useGenericTime = false)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void JoinFederationExecution(string federateName, string federateType, string fedExecutionName, string[] additionalFomModules, out FederateHandle handle, bool useGenericTime = false)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void ResignFederationExecution(ResignAction resignAction)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void RegisterFederationSynchronizationPoint(string label, VariableLengthData theUserSuppliedTag)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void RegisterFederationSynchronizationPoint(string label, VariableLengthData theUserSuppliedTag, IEnumerable<FederateHandle> synchronizationSet)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void SynchronizationPointAchieved(string label, bool successfully)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void RequestFederationSave(string label)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void RequestFederationSave(string label, LogicalTime theTime)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void FederateSaveBegun()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void FederateSaveComplete()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void FederateSaveNotComplete()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void AbortFederationSave()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void QueryFederationSaveStatus()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void RequestFederationRestore(string label)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void FederateRestoreComplete()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void FederateRestoreNotComplete()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void AbortFederationRestore()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void QueryFederationRestoreStatus()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void PublishObjectClassAttributes(ObjectClassHandle theClass, IEnumerable<AttributeHandle> attributeList)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void UnpublishObjectClass(ObjectClassHandle theClass)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void UnpublishObjectClassAttributes(ObjectClassHandle theClass, IEnumerable<AttributeHandle> attributeList)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void PublishInteractionClass(InteractionClassHandle theInteraction)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void UnpublishInteractionClass(InteractionClassHandle theInteraction)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void SubscribeObjectClassAttributes(ObjectClassHandle theClass, IEnumerable<AttributeHandle> attributeList, bool active = true, string updateRateDesignator = "")
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void UnsubscribeObjectClass(ObjectClassHandle theClass)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void UnsubscribeObjectClassAttributes(ObjectClassHandle theClass, IEnumerable<AttributeHandle> attributeList)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void SubscribeInteractionClass(InteractionClassHandle theClass, bool active = true)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void UnsubscribeInteractionClass(InteractionClassHandle theClass)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void ReserveObjectInstanceName(string theObjectInstanceName)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void ReleaseObjectInstanceName(string theObjectInstanceName)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void ReserveMultipleObjectInstanceName(string[] theObjectInstanceNames)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void ReleaseMultipleObjectInstanceName(string[] theObjectInstanceNames)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public ObjectInstanceHandle RegisterObjectInstance(ObjectClassHandle theClass)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public ObjectInstanceHandle RegisterObjectInstance(ObjectClassHandle theClass, string theObjectInstanceName)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void UpdateAttributeValues(ObjectInstanceHandle theObject, IDictionary<AttributeHandle, VariableLengthData> theAttributeValues)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void UpdateAttributeValues(ObjectInstanceHandle theObject, IDictionary<AttributeHandle, VariableLengthData> theAttributeValues, VariableLengthData theUserSuppliedTag)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public MessageRetractionHandle UpdateAttributeValues(ObjectInstanceHandle theObject, IDictionary<AttributeHandle, VariableLengthData> theAttributeValues, VariableLengthData theUserSuppliedTag, LogicalTime theTime)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void SendInteraction(InteractionClassHandle theInteraction, IDictionary<ParameterHandle, VariableLengthData> theParameterValues)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void SendInteraction(InteractionClassHandle theInteraction, IDictionary<ParameterHandle, VariableLengthData> theParameterValues, VariableLengthData theUserSuppliedTag)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public MessageRetractionHandle SendInteraction(InteractionClassHandle theInteraction, IDictionary<ParameterHandle, VariableLengthData> theParameterValues, VariableLengthData theUserSuppliedTag, LogicalTime theTime)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void DeleteObjectInstance(ObjectInstanceHandle theObject, VariableLengthData theUserSuppliedTag)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public MessageRetractionHandle DeleteObjectInstance(ObjectInstanceHandle theObject, VariableLengthData theUserSuppliedTag, LogicalTime theTime)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void LocalDeleteObjectInstance(ObjectInstanceHandle theObject)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void RequestAttributeValueUpdate(ObjectInstanceHandle theObject, IEnumerable<AttributeHandle> theAttributes, VariableLengthData theUserSuppliedTag)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void RequestAttributeValueUpdate(ObjectClassHandle theClass, IEnumerable<AttributeHandle> theAttributes, VariableLengthData theUserSuppliedTag)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void RequestAttributeTransportationTypeChange(ObjectInstanceHandle theObject, IEnumerable<AttributeHandle> theAttributes, TransportationType theType)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void QueryAttributeTransportationType(ObjectInstanceHandle theObject, AttributeHandle theAttribute)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void RequestInteractionTransportationTypeChange(InteractionClassHandle theClass, TransportationType theType)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void QueryInteractionTransportationType(FederateHandle theFederate, InteractionClassHandle theInteraction)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void UnconditionalAttributeOwnershipDivestiture(ObjectInstanceHandle theObject, IEnumerable<AttributeHandle> theAttributes)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void NegotiatedAttributeOwnershipDivestiture(ObjectInstanceHandle theObject, IEnumerable<AttributeHandle> theAttributes, VariableLengthData theUserSuppliedTag)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void ConfirmDivestiture(ObjectInstanceHandle theObject, IEnumerable<AttributeHandle> confirmedAttributes, VariableLengthData theUserSuppliedTag)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void AttributeOwnershipAcquisition(ObjectInstanceHandle theObject, IEnumerable<AttributeHandle> desiredAttributes, VariableLengthData theUserSuppliedTag)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void AttributeOwnershipAcquisitionIfAvailable(ObjectInstanceHandle theObject, IEnumerable<AttributeHandle> desiredAttributes)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void AttributeOwnershipReleaseDenied(ObjectInstanceHandle theObject, IEnumerable<AttributeHandle> theAttributes)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void AttributeOwnershipDivestitureIfWanted(ObjectInstanceHandle theObject, IEnumerable<AttributeHandle> theAttributes, IEnumerable<AttributeHandle> theDivestedAttributes)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void CancelNegotiatedAttributeOwnershipDivestiture(ObjectInstanceHandle theObject, IEnumerable<AttributeHandle> theAttributes)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void CancelAttributeOwnershipAcquisition(ObjectInstanceHandle theObject, IEnumerable<AttributeHandle> theAttributes)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void QueryAttributeOwnership(ObjectInstanceHandle theObject, AttributeHandle theAttribute)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public bool IsAttributeOwnedByFederate(ObjectInstanceHandle theObject, AttributeHandle theAttribute)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void EnableTimeRegulation(LogicalTimeInterval theLookahead)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void DisableTimeRegulation()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void EnableTimeConstrained()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void DisableTimeConstrained()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void TimeAdvanceRequest(LogicalTime theTime)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void TimeAdvanceRequestAvailable(LogicalTime theTime)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void NextMessageRequest(LogicalTime theTime)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void NextMessageRequestAvailable(LogicalTime theTime)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void FlushQueueRequest(LogicalTime theTime)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void EnableAsynchronousDelivery()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void DisableAsynchronousDelivery()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public bool QueryGALT(LogicalTime theTime)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void QueryLogicalTime(LogicalTime theTime)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public bool QueryLITS(LogicalTime theTime)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void ModifyLookahead(LogicalTimeInterval theLookahead)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void QueryLookahead(LogicalTimeInterval interval)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void Retract(MessageRetractionHandle theHandle)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void ChangeAttributeOrderType(ObjectInstanceHandle theObject, IEnumerable<AttributeHandle> theAttributes, OrderType theType)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void ChangeInteractionOrderType(InteractionClassHandle theClass, OrderType theType)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public RegionHandle CreateRegion(IEnumerable<DimensionHandle> theDimensions)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void CommitRegionModifications(IEnumerable<RegionHandle> theRegionHandleSet)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void DeleteRegion(RegionHandle theRegion)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public ObjectInstanceHandle RegisterObjectInstanceWithRegions(ObjectClassHandle theClass, List<AttributesRegionsMapping> theAttributesRegionsMappingVector)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public ObjectInstanceHandle RegisterObjectInstanceWithRegions(ObjectClassHandle theClass, List<AttributesRegionsMapping> theAttributesRegionsMappingVector, string theObjectInstanceName)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void AssociateRegionsForUpdates(ObjectInstanceHandle theObject, List<AttributesRegionsMapping> theAttributesRegionsMappingVector)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void UnassociateRegionsForUpdates(ObjectInstanceHandle theObject, List<AttributesRegionsMapping> theAttributesRegionsMappingVector)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void SubscribeObjectClassAttributesWithRegions(ObjectClassHandle theClass, List<AttributesRegionsMapping> theAttributesRegionsMappingVector, bool active, string updateRateDesignator)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void UnsubscribeObjectClassAttributesWithRegions(ObjectClassHandle theClass, List<AttributesRegionsMapping> theAttributesRegionsMappingVector)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void SubscribeInteractionClassWithRegions(InteractionClassHandle theClass, IEnumerable<RegionHandle> theRegionHandleSet, bool active)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void UnsubscribeInteractionClassWithRegions(InteractionClassHandle theClass, IEnumerable<RegionHandle> theRegionHandleSet)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void SendInteractionWithRegions(InteractionClassHandle theInteraction, IDictionary<ParameterHandle, VariableLengthData> theParameterValues, IEnumerable<RegionHandle> theRegionHandleSet, VariableLengthData theUserSuppliedTag)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public MessageRetractionHandle SendInteractionWithRegions(InteractionClassHandle theInteraction, IDictionary<ParameterHandle, VariableLengthData> theParameterValues, IEnumerable<RegionHandle> theRegionHandleSet, VariableLengthData theUserSuppliedTag, LogicalTime theTime)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void RequestAttributeValueUpdateWithRegions(ObjectClassHandle theClass, List<AttributesRegionsMapping> theAttributesRegionsMappingVector, VariableLengthData theUserSuppliedTag)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public ResignAction GetAutomaticResignDirective()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void SetAutomaticResignDirective(ResignAction resignAction)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public FederateHandle GetFederateHandle(string theName)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public string GetFederateName(FederateHandle theHandle)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public ObjectClassHandle GetObjectClassHandle(string theName)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public string GetObjectClassName(ObjectClassHandle theHandle)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public ObjectClassHandle GetKnownObjectClassHandle(ObjectInstanceHandle theObject)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public ObjectInstanceHandle GetObjectInstanceHandle(string theName)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public string GetObjectInstanceName(ObjectInstanceHandle theHandle)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public AttributeHandle GetAttributeHandle(ObjectClassHandle whichClass, string theAttributeName)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public string GetAttributeName(ObjectClassHandle whichClass, AttributeHandle theHandle)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public double GetUpdateRateValue(string updateRateDesignator)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public double GetUpdateRateValueForAttribute(ObjectInstanceHandle theObject, AttributeHandle theAttribute)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public InteractionClassHandle GetInteractionClassHandle(string theName)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public string GetInteractionClassName(InteractionClassHandle theHandle)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public ParameterHandle GetParameterHandle(InteractionClassHandle whichClass, string theName)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public string GetParameterName(InteractionClassHandle whichClass, ParameterHandle theHandle)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public OrderType GetOrderType(string orderName)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public string GetOrderName(OrderType orderType)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public TransportationType GetTransportationType(string transportationName)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public string GetTransportationName(TransportationType transportationType)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public DimensionHandle[] GetAvailableDimensionsForClassAttribute(ObjectClassHandle theClass, AttributeHandle theHandle)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public DimensionHandle[] GetAvailableDimensionsForInteractionClass(InteractionClassHandle theClass)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public DimensionHandle GetDimensionHandle(string theName)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public string GetDimensionName(DimensionHandle theHandle)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public ulong GetDimensionUpperBound(DimensionHandle theHandle)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public DimensionHandle[] GetDimensionHandleSet(RegionHandle theRegionHandle)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public RangeBounds GetRangeBounds(RegionHandle theRegionHandle, DimensionHandle theDimensionHandle)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void SetRangeBounds(RegionHandle theRegionHandle, DimensionHandle theDimensionHandle, RangeBounds theRangeBounds)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public ulong NormalizeFederateHandle(FederateHandle theFederateHandle)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public ulong NormalizeServiceGroup(ServiceGroup theServiceGroup)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void EnableObjectClassRelevanceAdvisorySwitch()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void DisableObjectClassRelevanceAdvisorySwitch()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void EnableAttributeRelevanceAdvisorySwitch()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void DisableAttributeRelevanceAdvisorySwitch()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void EnableAttributeScopeAdvisorySwitch()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void DisableAttributeScopeAdvisorySwitch()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void EnableInteractionRelevanceAdvisorySwitch()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void DisableInteractionRelevanceAdvisorySwitch()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public bool EvokeCallback(double approximateMinimumTimeInSeconds)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public bool EvokeMultipleCallbacks(double approximateMinimumTimeInSeconds, double approximateMaximumTimeInSeconds)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void EnableCallbacks()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void DisableCallbacks()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public LogicalTimeFactory GetTimeFactory()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public FederateHandle DecodeFederateHandle(VariableLengthData encodedValue)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public ObjectClassHandle DecodeObjectClassHandle(VariableLengthData encodedValue)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public InteractionClassHandle DecodeInteractionClassHandle(VariableLengthData encodedValue)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public ObjectInstanceHandle DecodeObjectInstanceHandle(VariableLengthData encodedValue)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public AttributeHandle DecodeAttributeHandle(VariableLengthData encodedValue)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public ParameterHandle DecodeParameterHandle(VariableLengthData encodedValue)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public DimensionHandle DecodeDimensionHandle(VariableLengthData encodedValue)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public MessageRetractionHandle DecodeMessageRetractionHandle(VariableLengthData encodedValue)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public RegionHandle DecodeRegionHandle(VariableLengthData encodedValue)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }
    }
}