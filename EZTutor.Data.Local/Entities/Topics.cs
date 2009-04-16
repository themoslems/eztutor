/*

insert license info here

*/

using System;
using System.Collections;
using System.Collections.Generic;


namespace EZTutor.Data.Local.Entities
{
    /// <summary>
    /// Generated by MyGeneration using the NHibernate Object Mapping 1.3.1 by Grimaldi Giuseppe (giuseppe.grimaldi@infracom.it)
    /// </summary>
    [Serializable]
    public class Topics 
    {
        #region Private Members
		
        // Variabili di stato
        private bool _isChanged;
        private bool _isDeleted;

        // Primary Key(s) 
        private Guid _topicid; 
		
        // Properties 
        private string _topicname; 		

        #endregion
		
        #region Default ( Empty ) Class Constructor
		
        /// <summary>
        /// default constructor
        /// </summary>
        public Topics()
        {
            _topicid = Guid.NewGuid(); 
            _topicname = ""; 
        }
		
        #endregion // End of Default ( Empty ) Class Constructor
		
        #region Full Constructor
		
        /// <summary>
        /// full constructor
        /// </summary>
        public Topics(Guid topicid, string topicname)
        {
            _topicid = topicid; 
            _topicname = topicname; 
        }
		
        #endregion // End Full Constructor

        #region Public Properties
			
        /// <summary>
        /// 
        /// </summary>		
        public virtual Guid Topicid
        {
            get { return _topicid; }
            set { _isChanged |= (_topicid != value); _topicid = value; }
        } 
	  
        /// <summary>
        /// 
        /// </summary>		
        public virtual string TopicName
        {
            get { return _topicname; }
            set { _isChanged |= (_topicname != value); _topicname = value; }
        } 
	  
        /// <summary>
        /// Returns whether or not the object has changed it's values.
        /// </summary>
        public virtual bool IsChanged
        {
            get { return _isChanged; }
        }
		
        /// <summary>
        /// Returns whether or not the object has changed it's values.
        /// </summary>
        public virtual bool IsDeleted
        {
            get { return _isDeleted; }
        }
		
        #endregion 
		
        #region Public Functions

        /// <summary>
        /// mark the item as deleted
        /// </summary>
        public virtual void MarkAsDeleted()
        {
            _isDeleted = true;
            _isChanged = true;
        }
		
        #endregion
		
        #region Equals And HashCode Overrides
		
        /// <summary>
        /// local implementation of Equals based on unique value members
        /// </summary>
        public override bool Equals( object obj )
        {
            if( this == obj ) return true;
            if( ( obj == null ) || ( obj.GetType() != this.GetType() ) ) return false;
            Topics castObj = (Topics)obj; 
            return ( castObj != null ) &&
                   ( this._topicid == castObj.Topicid );
        }
		
        /// <summary>
        /// local implementation of GetHashCode based on unique value members
        /// </summary>
        public override int GetHashCode()
        { 
            int hash = 57; 
            hash = 27 * hash * this._topicid.GetHashCode();
					
            return hash;		
			
        }
		
        #endregion
		
    }
}