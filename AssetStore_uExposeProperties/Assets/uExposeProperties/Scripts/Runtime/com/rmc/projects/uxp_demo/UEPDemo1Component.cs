/**
 * Copyright (C) 2005-2013 by Rivello Multimedia Consulting (RMC).                    
 * code [at] RivelloMultimediaConsulting [dot] com                                                  
 *                                                                      
 * Permission is hereby granted, free of charge, to any person obtaining
 * a copy of this software and associated documentation files (the      
 * "Software"), to deal in the Software without restriction, including  
 * without limitation the rights to use, copy, modify, merge, publish,  
 * distribute, sublicense, and#or sell copies of the Software, and to   
 * permit persons to whom the Software is furnished to do so, subject to
 * the following conditions:                                            
 *                                                                      
 * The above copyright notice and this permission notice shall be       
 * included in all copies or substantial portions of the Software.      
 *                                                                      
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,      
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF   
 * MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
 * IN NO EVENT SHALL THE AUTHORS BE LIABLE FOR ANY CLAIM, DAMAGES OR    
 * OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
 * ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.                                      
 */
// Marks the right margin of code *******************************************************************


//--------------------------------------
//  Imports
//--------------------------------------
using UnityEngine;
using com.unity3d.wiki.expose_properties;

//--------------------------------------
//  Namespace
//--------------------------------------
namespace com.rmc.projects.uxp_demo
{
	
	//--------------------------------------
	//  Namespace Properties
	//--------------------------------------
	
	//--------------------------------------
	//  Class Attributes
	//--------------------------------------
	
	//--------------------------------------
	//  Class
	//--------------------------------------
	public class UEPDemo1Component : MonoBehaviour 
	{
		
		//--------------------------------------
		//  Attributes
		//--------------------------------------

		/// <summary>
		/// 
		/// 1. uEXP works with the following types;
		/// 
		/// 		int
		/// 		float
		/// 		bool
		/// 		string
		/// 		vector2
		/// 		vector3
		/// 		enum (e.g. AnyCustomEnum)
		/// 
		/// 2. But you can easily make ANY type work (see ExposeProperties.cs)
		/// 
		/// 
		/// 3. NOTE: uEXP currently relies on 'event handler' OnInspectorGUI to operate. 
		/// 			Considering this, it would be most run-time efficent to NOT use eEXP. 
		/// 			Or to use an alternative 'event handler'.
		/// 			Consider that before using it.
		/// 
		/// 
		/// 4. Suggestions (especially per #3)?
		/// 
		/// 
		/// </summary>
		public enum AnyCustomEnum
		{
			SampleValue1,
			SampleValue2

		}


		//--------------------------------------
		//  Properties
		//--------------------------------------
		
		/// <summary>
		/// SAMPLE VALUE: enum
		/// 
		/// NOTE: This uEXP does not interact with any other uEXP. Very common.
		/// 
		/// 
		/// </summary>
		[SerializeField][HideInInspector]
		private AnyCustomEnum _someCustomEnum;
		[ExposeProperty]
		public AnyCustomEnum someCustomEnum {
			get{
				return _someCustomEnum;
			}
			set{
				_someCustomEnum = value;

			}
		}

		//--------------------------------------
		//--------------------------------------


		/// <summary>
		/// SAMPLE VALUE: float
		/// 
		/// NOTE: We show how min and max affect each other 'live' in the inspector
		/// 
		/// </summary>
		[SerializeField][HideInInspector]
		private float _sampleMinimumNumber_float = 0.2f;
		[ExposeProperty]
		public float sampleMinimumNumber {
			get{
				return _sampleMinimumNumber_float;
			}
			set{
				_sampleMinimumNumber_float = Mathf.Clamp (value, 0, _sampleMaximumNumber_float);
				
				//
				_doRefreshProperties();
			}
		}

		/// <summary>
		/// SAMPLE VALUE: int
		/// 
		/// NOTE: We show how 'current' will be correct if 'min' or 'max' change. Common use case.
		/// 
		/// </summary>
		[SerializeField][HideInInspector]
		private int _sampleCurrentNumber_int = 12;
		[ExposeProperty]
		public int sampleCurrentNumber {
			get{
				return _sampleCurrentNumber_int;
			}
			set{
				_sampleCurrentNumber_int = (int) Mathf.Clamp (value, _sampleMinimumNumber_float, _sampleMaximumNumber_float);
				
				//
				_doRefreshProperties();
			}
		}

		/// <summary>
		/// SAMPLE VALUE: float
		/// 
		/// NOTE: We show how min and max affect each other 'live' in the inspector
		/// 
		/// </summary>
		[SerializeField][HideInInspector]
		private float _sampleMaximumNumber_float = 19.9f;
		[ExposeProperty]
		public float sampleMaximumNumber {
			get{
				return _sampleMaximumNumber_float;
			}
			set{
				_sampleMaximumNumber_float = Mathf.Clamp (value, _sampleMinimumNumber_float, Mathf.Infinity);
				
				//
				_doRefreshProperties();
			}
		}
		

		
		//--------------------------------------
		//--------------------------------------



		
		

		//--------------------------------------
		//  Methods
		//--------------------------------------	

		//	PUBLIC 

		/// <summary>
		/// Start this instance.
		/// </summary>
		void Start () 
		{

		}
		
		
		///<summary>
		///	Called once per frame
		///</summary>
		void Update () 
		{


		}


		//	PRIVATE 
		/// <summary>
		/// 
		/// Refresh properties.
		/// 
		/// NOTE: This is NOT a required pattern for UEXP
		/// NOTE: This is recommended when;
		/// 		You have interdependent properties to coordiate
		/// 		Or you want to have all changes do something (e.g. rotate)
		/// 
		/// </summary>
		private void _doRefreshProperties() 
		{
			gameObject.transform.Rotate ( new Vector3 (0, 1, 0));
			
		}

		//--------------------------------------
		//  Events
		//--------------------------------------
		/// <summary>
		/// Raises the enable event.
		/// 
		/// NOTE: This is not a required pattern for UEXP
		/// NOTE: This is recommended if you want clicking off/on the inspector to update values
		/// 
		/// </summary>
		void OnEnable ()
		{
			//REFRESH PRIORITY
			_doRefreshProperties();

		}

		
	}
}
