﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Original file name:
// Generation date: 20.11.2020 0:21:43
namespace Simple
{

    /// <summary>
    /// There are no comments for Simple.TestType in the schema.
    /// </summary>
    /// <KeyProperties>
    /// KeyProp
    /// </KeyProperties>
    [global::System.Data.Services.Common.DataServiceKeyAttribute("KeyProp")]
    public partial class TestType
    {
        /// <summary>
        /// Create a new TestType object.
        /// </summary>
        /// <param name="keyProp">Initial value of KeyProp.</param>
        /// <param name="valueProp">Initial value of ValueProp.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static TestType CreateTestType(int keyProp, string valueProp)
        {
            TestType testType = new TestType();
            testType.KeyProp = keyProp;
            testType.ValueProp = valueProp;
            return testType;
        }
        /// <summary>
        /// There are no comments for Property KeyProp in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int KeyProp
        {
            get
            {
                return this._KeyProp;
            }
            set
            {
                this.OnKeyPropChanging(value);
                this._KeyProp = value;
                this.OnKeyPropChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _KeyProp;
        partial void OnKeyPropChanging(int value);
        partial void OnKeyPropChanged();
        /// <summary>
        /// There are no comments for Property ValueProp in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ValueProp
        {
            get
            {
                return this._ValueProp;
            }
            set
            {
                this.OnValuePropChanging(value);
                this._ValueProp = value;
                this.OnValuePropChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ValueProp;
        partial void OnValuePropChanging(string value);
        partial void OnValuePropChanged();
    }
}