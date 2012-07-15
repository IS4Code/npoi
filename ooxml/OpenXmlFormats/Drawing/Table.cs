// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>NPOI.OpenXmlFormats.Dml</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>True</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace NPOI.OpenXmlFormats.Dml
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Collections.Generic;


    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [XmlRoot("tbl", Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = false)]
    public partial class CT_Table
    {

        private CT_TableProperties tblPrField;

        private List<CT_TableCol> tblGridField;

        private List<CT_TableRow> trField;

        public CT_Table()
        {
            this.trField = new List<CT_TableRow>();
            this.tblGridField = new List<CT_TableCol>();
            this.tblPrField = new CT_TableProperties();
        }

        [XmlElement(Order = 0)]
        public CT_TableProperties tblPr
        {
            get
            {
                return this.tblPrField;
            }
            set
            {
                this.tblPrField = value;
            }
        }

        [XmlArray(Order = 1)]
        [XmlArrayItem("gridCol", IsNullable = false)]
        public List<CT_TableCol> tblGrid
        {
            get
            {
                return this.tblGridField;
            }
            set
            {
                this.tblGridField = value;
            }
        }

        [XmlElement("tr", Order = 2)]
        public List<CT_TableRow> tr
        {
            get
            {
                return this.trField;
            }
            set
            {
                this.trField = value;
            }
        }
    }


    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
    public partial class CT_TableProperties
    {

        private CT_NoFillProperties noFillField;

        private CT_SolidColorFillProperties solidFillField;

        private CT_GradientFillProperties gradFillField;

        private CT_BlipFillProperties blipFillField;

        private CT_PatternFillProperties pattFillField;

        private CT_GroupFillProperties grpFillField;

        private CT_EffectList effectLstField;

        private CT_EffectContainer effectDagField;

        private object itemField;

        private CT_OfficeArtExtensionList extLstField;

        private bool rtlField;

        private bool firstRowField;

        private bool firstColField;

        private bool lastRowField;

        private bool lastColField;

        private bool bandRowField;

        private bool bandColField;

        public CT_TableProperties()
        {
            this.extLstField = new CT_OfficeArtExtensionList();
            this.effectDagField = new CT_EffectContainer();
            this.effectLstField = new CT_EffectList();
            this.grpFillField = new CT_GroupFillProperties();
            this.pattFillField = new CT_PatternFillProperties();
            this.blipFillField = new CT_BlipFillProperties();
            this.gradFillField = new CT_GradientFillProperties();
            this.solidFillField = new CT_SolidColorFillProperties();
            this.noFillField = new CT_NoFillProperties();
            this.rtlField = false;
            this.firstRowField = false;
            this.firstColField = false;
            this.lastRowField = false;
            this.lastColField = false;
            this.bandRowField = false;
            this.bandColField = false;
        }

        [XmlElement(Order = 0)]
        public CT_NoFillProperties noFill
        {
            get
            {
                return this.noFillField;
            }
            set
            {
                this.noFillField = value;
            }
        }

        [XmlElement(Order = 1)]
        public CT_SolidColorFillProperties solidFill
        {
            get
            {
                return this.solidFillField;
            }
            set
            {
                this.solidFillField = value;
            }
        }

        [XmlElement(Order = 2)]
        public CT_GradientFillProperties gradFill
        {
            get
            {
                return this.gradFillField;
            }
            set
            {
                this.gradFillField = value;
            }
        }

        [XmlElement(Order = 3)]
        public CT_BlipFillProperties blipFill
        {
            get
            {
                return this.blipFillField;
            }
            set
            {
                this.blipFillField = value;
            }
        }

        [XmlElement(Order = 4)]
        public CT_PatternFillProperties pattFill
        {
            get
            {
                return this.pattFillField;
            }
            set
            {
                this.pattFillField = value;
            }
        }

        [XmlElement(Order = 5)]
        public CT_GroupFillProperties grpFill
        {
            get
            {
                return this.grpFillField;
            }
            set
            {
                this.grpFillField = value;
            }
        }

        [XmlElement(Order = 6)]
        public CT_EffectList effectLst
        {
            get
            {
                return this.effectLstField;
            }
            set
            {
                this.effectLstField = value;
            }
        }

        [XmlElement(Order = 7)]
        public CT_EffectContainer effectDag
        {
            get
            {
                return this.effectDagField;
            }
            set
            {
                this.effectDagField = value;
            }
        }

        [XmlElement("tableStyle", typeof(CT_TableStyle), Order = 8)]
        [XmlElement("tableStyleId", typeof(string), DataType = "token", Order = 8)]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        [XmlElement(Order = 9)]
        public CT_OfficeArtExtensionList extLst
        {
            get
            {
                return this.extLstField;
            }
            set
            {
                this.extLstField = value;
            }
        }

        [XmlAttribute]
        [DefaultValue(false)]
        public bool rtl
        {
            get
            {
                return this.rtlField;
            }
            set
            {
                this.rtlField = value;
            }
        }

        [XmlAttribute]
        [DefaultValue(false)]
        public bool firstRow
        {
            get
            {
                return this.firstRowField;
            }
            set
            {
                this.firstRowField = value;
            }
        }

        [XmlAttribute]
        [DefaultValue(false)]
        public bool firstCol
        {
            get
            {
                return this.firstColField;
            }
            set
            {
                this.firstColField = value;
            }
        }

        [XmlAttribute]
        [DefaultValue(false)]
        public bool lastRow
        {
            get
            {
                return this.lastRowField;
            }
            set
            {
                this.lastRowField = value;
            }
        }

        [XmlAttribute]
        [DefaultValue(false)]
        public bool lastCol
        {
            get
            {
                return this.lastColField;
            }
            set
            {
                this.lastColField = value;
            }
        }

        [XmlAttribute]
        [DefaultValue(false)]
        public bool bandRow
        {
            get
            {
                return this.bandRowField;
            }
            set
            {
                this.bandRowField = value;
            }
        }

        [XmlAttribute]
        [DefaultValue(false)]
        public bool bandCol
        {
            get
            {
                return this.bandColField;
            }
            set
            {
                this.bandColField = value;
            }
        }
    }


    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
    public partial class CT_TableCol
    {

        private CT_OfficeArtExtensionList extLstField;

        private long wField;

        public CT_TableCol()
        {
            this.extLstField = new CT_OfficeArtExtensionList();
        }

        [XmlElement(Order = 0)]
        public CT_OfficeArtExtensionList extLst
        {
            get
            {
                return this.extLstField;
            }
            set
            {
                this.extLstField = value;
            }
        }

        [XmlAttribute]
        public long w
        {
            get
            {
                return this.wField;
            }
            set
            {
                this.wField = value;
            }
        }
    }


    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
    public partial class CT_TableRow
    {

        private List<CT_TableCell> tcField;

        private CT_OfficeArtExtensionList extLstField;

        private long hField;

        public CT_TableRow()
        {
            this.extLstField = new CT_OfficeArtExtensionList();
            this.tcField = new List<CT_TableCell>();
        }

        [XmlElement("tc", Order = 0)]
        public List<CT_TableCell> tc
        {
            get
            {
                return this.tcField;
            }
            set
            {
                this.tcField = value;
            }
        }

        [XmlElement(Order = 1)]
        public CT_OfficeArtExtensionList extLst
        {
            get
            {
                return this.extLstField;
            }
            set
            {
                this.extLstField = value;
            }
        }

        [XmlAttribute]
        public long h
        {
            get
            {
                return this.hField;
            }
            set
            {
                this.hField = value;
            }
        }
    }


    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
    public partial class CT_TableCell
    {

        private CT_TextBody txBodyField;

        private CT_TableCellProperties tcPrField;

        private CT_OfficeArtExtensionList extLstField;

        private int rowSpanField;

        private int gridSpanField;

        private bool hMergeField;

        private bool vMergeField;

        public CT_TableCell()
        {
            this.extLstField = new CT_OfficeArtExtensionList();
            this.tcPrField = new CT_TableCellProperties();
            this.txBodyField = new CT_TextBody();
            this.rowSpanField = 1;
            this.gridSpanField = 1;
            this.hMergeField = false;
            this.vMergeField = false;
        }

        [XmlElement(Order = 0)]
        public CT_TextBody txBody
        {
            get
            {
                return this.txBodyField;
            }
            set
            {
                this.txBodyField = value;
            }
        }

        [XmlElement(Order = 1)]
        public CT_TableCellProperties tcPr
        {
            get
            {
                return this.tcPrField;
            }
            set
            {
                this.tcPrField = value;
            }
        }

        [XmlElement(Order = 2)]
        public CT_OfficeArtExtensionList extLst
        {
            get
            {
                return this.extLstField;
            }
            set
            {
                this.extLstField = value;
            }
        }

        [XmlAttribute]
        [DefaultValue(1)]
        public int rowSpan
        {
            get
            {
                return this.rowSpanField;
            }
            set
            {
                this.rowSpanField = value;
            }
        }

        [XmlAttribute]
        [DefaultValue(1)]
        public int gridSpan
        {
            get
            {
                return this.gridSpanField;
            }
            set
            {
                this.gridSpanField = value;
            }
        }

        [XmlAttribute]
        [DefaultValue(false)]
        public bool hMerge
        {
            get
            {
                return this.hMergeField;
            }
            set
            {
                this.hMergeField = value;
            }
        }

        [XmlAttribute]
        [DefaultValue(false)]
        public bool vMerge
        {
            get
            {
                return this.vMergeField;
            }
            set
            {
                this.vMergeField = value;
            }
        }
    }



    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
    public partial class CT_TableCellProperties
    {

        private CT_LineProperties lnLField;

        private CT_LineProperties lnRField;

        private CT_LineProperties lnTField;

        private CT_LineProperties lnBField;

        private CT_LineProperties lnTlToBrField;

        private CT_LineProperties lnBlToTrField;

        private CT_Cell3D cell3DField;

        private CT_NoFillProperties noFillField;

        private CT_SolidColorFillProperties solidFillField;

        private CT_GradientFillProperties gradFillField;

        private CT_BlipFillProperties blipFillField;

        private CT_PatternFillProperties pattFillField;

        private CT_GroupFillProperties grpFillField;

        private CT_OfficeArtExtensionList extLstField;

        private int marLField;

        private int marRField;

        private int marTField;

        private int marBField;

        private ST_TextVerticalType vertField;

        private ST_TextAnchoringType anchorField;

        private bool anchorCtrField;

        private ST_TextHorzOverflowType horzOverflowField;

        public CT_TableCellProperties()
        {
            this.extLstField = new CT_OfficeArtExtensionList();
            this.grpFillField = new CT_GroupFillProperties();
            this.pattFillField = new CT_PatternFillProperties();
            this.blipFillField = new CT_BlipFillProperties();
            this.gradFillField = new CT_GradientFillProperties();
            this.solidFillField = new CT_SolidColorFillProperties();
            this.noFillField = new CT_NoFillProperties();
            this.cell3DField = new CT_Cell3D();
            this.lnBlToTrField = new CT_LineProperties();
            this.lnTlToBrField = new CT_LineProperties();
            this.lnBField = new CT_LineProperties();
            this.lnTField = new CT_LineProperties();
            this.lnRField = new CT_LineProperties();
            this.lnLField = new CT_LineProperties();
            this.marLField = 91440;
            this.marRField = 91440;
            this.marTField = 45720;
            this.marBField = 45720;
            this.vertField = ST_TextVerticalType.horz;
            this.anchorField = ST_TextAnchoringType.t;
            this.anchorCtrField = false;
            this.horzOverflowField = ST_TextHorzOverflowType.clip;
        }

        [XmlElement(Order = 0)]
        public CT_LineProperties lnL
        {
            get
            {
                return this.lnLField;
            }
            set
            {
                this.lnLField = value;
            }
        }

        [XmlElement(Order = 1)]
        public CT_LineProperties lnR
        {
            get
            {
                return this.lnRField;
            }
            set
            {
                this.lnRField = value;
            }
        }

        [XmlElement(Order = 2)]
        public CT_LineProperties lnT
        {
            get
            {
                return this.lnTField;
            }
            set
            {
                this.lnTField = value;
            }
        }

        [XmlElement(Order = 3)]
        public CT_LineProperties lnB
        {
            get
            {
                return this.lnBField;
            }
            set
            {
                this.lnBField = value;
            }
        }

        [XmlElement(Order = 4)]
        public CT_LineProperties lnTlToBr
        {
            get
            {
                return this.lnTlToBrField;
            }
            set
            {
                this.lnTlToBrField = value;
            }
        }

        [XmlElement(Order = 5)]
        public CT_LineProperties lnBlToTr
        {
            get
            {
                return this.lnBlToTrField;
            }
            set
            {
                this.lnBlToTrField = value;
            }
        }

        [XmlElement(Order = 6)]
        public CT_Cell3D cell3D
        {
            get
            {
                return this.cell3DField;
            }
            set
            {
                this.cell3DField = value;
            }
        }

        [XmlElement(Order = 7)]
        public CT_NoFillProperties noFill
        {
            get
            {
                return this.noFillField;
            }
            set
            {
                this.noFillField = value;
            }
        }

        [XmlElement(Order = 8)]
        public CT_SolidColorFillProperties solidFill
        {
            get
            {
                return this.solidFillField;
            }
            set
            {
                this.solidFillField = value;
            }
        }

        [XmlElement(Order = 9)]
        public CT_GradientFillProperties gradFill
        {
            get
            {
                return this.gradFillField;
            }
            set
            {
                this.gradFillField = value;
            }
        }

        [XmlElement(Order = 10)]
        public CT_BlipFillProperties blipFill
        {
            get
            {
                return this.blipFillField;
            }
            set
            {
                this.blipFillField = value;
            }
        }

        [XmlElement(Order = 11)]
        public CT_PatternFillProperties pattFill
        {
            get
            {
                return this.pattFillField;
            }
            set
            {
                this.pattFillField = value;
            }
        }

        [XmlElement(Order = 12)]
        public CT_GroupFillProperties grpFill
        {
            get
            {
                return this.grpFillField;
            }
            set
            {
                this.grpFillField = value;
            }
        }

        [XmlElement(Order = 13)]
        public CT_OfficeArtExtensionList extLst
        {
            get
            {
                return this.extLstField;
            }
            set
            {
                this.extLstField = value;
            }
        }

        [XmlAttribute]
        [DefaultValue(91440)]
        public int marL
        {
            get
            {
                return this.marLField;
            }
            set
            {
                this.marLField = value;
            }
        }

        [XmlAttribute]
        [DefaultValue(91440)]
        public int marR
        {
            get
            {
                return this.marRField;
            }
            set
            {
                this.marRField = value;
            }
        }

        [XmlAttribute]
        [DefaultValue(45720)]
        public int marT
        {
            get
            {
                return this.marTField;
            }
            set
            {
                this.marTField = value;
            }
        }

        [XmlAttribute]
        [DefaultValue(45720)]
        public int marB
        {
            get
            {
                return this.marBField;
            }
            set
            {
                this.marBField = value;
            }
        }

        [XmlAttribute]
        [DefaultValue(ST_TextVerticalType.horz)]
        public ST_TextVerticalType vert
        {
            get
            {
                return this.vertField;
            }
            set
            {
                this.vertField = value;
            }
        }

        [XmlAttribute]
        [DefaultValue(ST_TextAnchoringType.t)]
        public ST_TextAnchoringType anchor
        {
            get
            {
                return this.anchorField;
            }
            set
            {
                this.anchorField = value;
            }
        }

        [XmlAttribute]
        [DefaultValue(false)]
        public bool anchorCtr
        {
            get
            {
                return this.anchorCtrField;
            }
            set
            {
                this.anchorCtrField = value;
            }
        }

        [XmlAttribute]
        [DefaultValue(ST_TextHorzOverflowType.clip)]
        public ST_TextHorzOverflowType horzOverflow
        {
            get
            {
                return this.horzOverflowField;
            }
            set
            {
                this.horzOverflowField = value;
            }
        }
    }


    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
    public partial class CT_TableGrid
    {

        private List<CT_TableCol> gridColField;

        public CT_TableGrid()
        {
            this.gridColField = new List<CT_TableCol>();
        }

        [XmlElement("gridCol", Order = 0)]
        public List<CT_TableCol> gridCol
        {
            get
            {
                return this.gridColField;
            }
            set
            {
                this.gridColField = value;
            }
        }
    }
}