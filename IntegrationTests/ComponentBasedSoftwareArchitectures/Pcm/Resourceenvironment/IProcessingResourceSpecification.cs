//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMFExamples.Identifier;
using NMFExamples.Pcm.Core;
using NMFExamples.Pcm.Core.Entity;
using NMFExamples.Pcm.Resourcetype;
using NMF.Collections.Generic;
using NMF.Collections.ObjectModel;
using NMF.Expressions;
using NMF.Expressions.Linq;
using NMF.Models;
using NMF.Models.Collections;
using NMF.Models.Expressions;
using NMF.Models.Meta;
using NMF.Models.Repository;
using NMF.Serialization;
using NMF.Utilities;
using System;
using global::System.Collections;
using global::System.Collections.Generic;
using global::System.Collections.ObjectModel;
using global::System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace NMFExamples.Pcm.Resourceenvironment
{
    
    
    /// <summary>
    /// The public interface for ProcessingResourceSpecification
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ProcessingResourceSpecification))]
    [XmlDefaultImplementationTypeAttribute(typeof(ProcessingResourceSpecification))]
    public interface IProcessingResourceSpecification : IModelElement, IIdentifier
    {
        
        /// <summary>
        /// The MTTR property
        /// </summary>
        double MTTR
        {
            get;
            set;
        }
        
        /// <summary>
        /// The MTTF property
        /// </summary>
        double MTTF
        {
            get;
            set;
        }
        
        /// <summary>
        /// The requiredByContainer property
        /// </summary>
        bool RequiredByContainer
        {
            get;
            set;
        }
        
        /// <summary>
        /// The numberOfReplicas property
        /// </summary>
        int NumberOfReplicas
        {
            get;
            set;
        }
        
        /// <summary>
        /// The schedulingPolicy property
        /// </summary>
        ISchedulingPolicy SchedulingPolicy
        {
            get;
            set;
        }
        
        /// <summary>
        /// The activeResourceType_ActiveResourceSpecification property
        /// </summary>
        IProcessingResourceType ActiveResourceType_ActiveResourceSpecification
        {
            get;
            set;
        }
        
        /// <summary>
        /// The processingRate_ProcessingResourceSpecification property
        /// </summary>
        IPCMRandomVariable ProcessingRate_ProcessingResourceSpecification
        {
            get;
            set;
        }
        
        /// <summary>
        /// The resourceContainer_ProcessingResourceSpecification property
        /// </summary>
        IResourceContainer ResourceContainer_ProcessingResourceSpecification
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the MTTR property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> MTTRChanging;
        
        /// <summary>
        /// Gets fired when the MTTR property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> MTTRChanged;
        
        /// <summary>
        /// Gets fired before the MTTF property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> MTTFChanging;
        
        /// <summary>
        /// Gets fired when the MTTF property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> MTTFChanged;
        
        /// <summary>
        /// Gets fired before the RequiredByContainer property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> RequiredByContainerChanging;
        
        /// <summary>
        /// Gets fired when the RequiredByContainer property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> RequiredByContainerChanged;
        
        /// <summary>
        /// Gets fired before the NumberOfReplicas property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> NumberOfReplicasChanging;
        
        /// <summary>
        /// Gets fired when the NumberOfReplicas property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> NumberOfReplicasChanged;
        
        /// <summary>
        /// Gets fired before the SchedulingPolicy property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> SchedulingPolicyChanging;
        
        /// <summary>
        /// Gets fired when the SchedulingPolicy property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> SchedulingPolicyChanged;
        
        /// <summary>
        /// Gets fired before the ActiveResourceType_ActiveResourceSpecification property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> ActiveResourceType_ActiveResourceSpecificationChanging;
        
        /// <summary>
        /// Gets fired when the ActiveResourceType_ActiveResourceSpecification property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> ActiveResourceType_ActiveResourceSpecificationChanged;
        
        /// <summary>
        /// Gets fired before the ProcessingRate_ProcessingResourceSpecification property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> ProcessingRate_ProcessingResourceSpecificationChanging;
        
        /// <summary>
        /// Gets fired when the ProcessingRate_ProcessingResourceSpecification property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> ProcessingRate_ProcessingResourceSpecificationChanged;
        
        /// <summary>
        /// Gets fired before the ResourceContainer_ProcessingResourceSpecification property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> ResourceContainer_ProcessingResourceSpecificationChanging;
        
        /// <summary>
        /// Gets fired when the ResourceContainer_ProcessingResourceSpecification property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> ResourceContainer_ProcessingResourceSpecificationChanged;
    }
}

