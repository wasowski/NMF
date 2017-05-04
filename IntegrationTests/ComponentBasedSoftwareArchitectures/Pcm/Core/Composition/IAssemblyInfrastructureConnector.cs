//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMFExamples.Pcm.Core;
using NMFExamples.Pcm.Core.Entity;
using NMFExamples.Pcm.Parameter;
using NMFExamples.Pcm.Repository;
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

namespace NMFExamples.Pcm.Core.Composition
{
    
    
    /// <summary>
    /// The public interface for AssemblyInfrastructureConnector
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(AssemblyInfrastructureConnector))]
    [XmlDefaultImplementationTypeAttribute(typeof(AssemblyInfrastructureConnector))]
    public interface IAssemblyInfrastructureConnector : IModelElement, IConnector
    {
        
        /// <summary>
        /// The providedRole__AssemblyInfrastructureConnector property
        /// </summary>
        IInfrastructureProvidedRole ProvidedRole__AssemblyInfrastructureConnector
        {
            get;
            set;
        }
        
        /// <summary>
        /// The requiredRole__AssemblyInfrastructureConnector property
        /// </summary>
        IInfrastructureRequiredRole RequiredRole__AssemblyInfrastructureConnector
        {
            get;
            set;
        }
        
        /// <summary>
        /// The providingAssemblyContext__AssemblyInfrastructureConnector property
        /// </summary>
        IAssemblyContext ProvidingAssemblyContext__AssemblyInfrastructureConnector
        {
            get;
            set;
        }
        
        /// <summary>
        /// The requiringAssemblyContext__AssemblyInfrastructureConnector property
        /// </summary>
        IAssemblyContext RequiringAssemblyContext__AssemblyInfrastructureConnector
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the ProvidedRole__AssemblyInfrastructureConnector property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> ProvidedRole__AssemblyInfrastructureConnectorChanging;
        
        /// <summary>
        /// Gets fired when the ProvidedRole__AssemblyInfrastructureConnector property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> ProvidedRole__AssemblyInfrastructureConnectorChanged;
        
        /// <summary>
        /// Gets fired before the RequiredRole__AssemblyInfrastructureConnector property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> RequiredRole__AssemblyInfrastructureConnectorChanging;
        
        /// <summary>
        /// Gets fired when the RequiredRole__AssemblyInfrastructureConnector property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> RequiredRole__AssemblyInfrastructureConnectorChanged;
        
        /// <summary>
        /// Gets fired before the ProvidingAssemblyContext__AssemblyInfrastructureConnector property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> ProvidingAssemblyContext__AssemblyInfrastructureConnectorChanging;
        
        /// <summary>
        /// Gets fired when the ProvidingAssemblyContext__AssemblyInfrastructureConnector property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> ProvidingAssemblyContext__AssemblyInfrastructureConnectorChanged;
        
        /// <summary>
        /// Gets fired before the RequiringAssemblyContext__AssemblyInfrastructureConnector property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> RequiringAssemblyContext__AssemblyInfrastructureConnectorChanging;
        
        /// <summary>
        /// Gets fired when the RequiringAssemblyContext__AssemblyInfrastructureConnector property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> RequiringAssemblyContext__AssemblyInfrastructureConnectorChanged;
    }
}
