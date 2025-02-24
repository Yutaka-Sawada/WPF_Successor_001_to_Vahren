﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Successor_001_to_Vahren._010_Enum;

namespace WPF_Successor_001_to_Vahren._005_Class
{
    public class ClassPower
    {
        public ClassPower ShallowCopy()
        {
            return (ClassPower)MemberwiseClone();
        }
        public ClassPower DeepCopy()
        {
            ClassPower cp = ShallowCopy();
            // 配列など参照型のデータを新規作成して元の値をコピーする
            cp.ListHome = new List<string>(cp.ListHome);
            cp.ListMember = new List<string>(cp.ListMember);
            cp.ListCommonConscription = new List<string>(cp.ListCommonConscription);
            return cp;
        }

        #region Index
        private int _index;
        public int Index
        {
            get { return _index; }
            set { _index = value; }
        }
        #endregion
        #region IsDownfall
        private bool isDownfall = false;
        public bool IsDownfall
        {
            get { return isDownfall; }
            set { isDownfall = value; }
        }
        #endregion


        #region NameTag
        private string _nameTag = string.Empty;
        public string NameTag
        {
            get { return _nameTag; }
            set { _nameTag = value; }
        }
        #endregion
        #region Name
        private string _name = string.Empty;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        #endregion
        #region Help
        private string help = string.Empty;
        public string Help
        {
            get { return help; }
            set { help = value; }
        }
        #endregion
        #region Money
        private int _money;
        public int Money
        {
            get { return _money; }
            set { _money = value; }
        }
        #endregion
        #region FlagPath
        private string _flagPath = string.Empty;
        public string FlagPath
        {
            get { return _flagPath; }
            set { _flagPath = value; }
        }
        #endregion
        #region MasterTag
        private string _masterTag = string.Empty;
        public string MasterTag
        {
            get { return _masterTag; }
            set { _masterTag = value; }
        }
        #endregion
        #region ListHome
        /// <summary>
        /// 勢力のホーム領地を示します。COMの思考に影響します。列挙された領地方面の攻略、奪還を優先するようになります。
        /// </summary>
        private List<string> _listHome = new List<string>();
        public List<string> ListHome
        {
            get { return _listHome; }
            set { _listHome = value; }
        }
        #endregion
        #region Head
        private string _head = string.Empty;
        public string Head
        {
            get { return _head; }
            set { _head = value; }
        }
        #endregion
        #region Diff
        private string _diff = string.Empty;
        public string Diff
        {
            get { return _diff; }
            set { _diff = value; }
        }
        #endregion
        #region EnableSelect
        private string _enableSelect = string.Empty;
        public string EnableSelect
        {
            get { return _enableSelect; }
            set { _enableSelect = value; }
        }
        #endregion
        #region Text
        private string _text = string.Empty;
        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }
        #endregion
        #region ListMember
        /// <summary>
        /// ClassGameStatus.ListPowerでは開始時の領地。
        /// ClassGameStatus.NowListPowerでは現在の領地。
        /// </summary>
        private List<string> _listMember = new List<string>();
        public List<string> ListMember
        {
            get { return _listMember; }
            set { _listMember = value; }
        }
        #endregion
        #region Image
        private string _image = string.Empty;
        public string Image
        {
            get { return _image; }
            set { _image = value; }
        }
        #endregion
        #region ListCommonConscription
        private List<string> _listCommonConscription = new List<string>();
        public List<string> ListCommonConscription
        {
            get { return _listCommonConscription; }
            set { _listCommonConscription = value; }
        }
        #endregion
        #region Fix
        private FlagPowerFix fix;
        public FlagPowerFix Fix
        {
            get { return fix; }
            set { fix = value; }
        }
        #endregion

    }
}
