﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_15_Encapsulation_PartialClass
{
    partial class cData
    {
        private double _dTotalPrice = 0.0;
        public double DTotalPrice
        {
            get { return _dTotalPrice; }

            set
            {
                _dTotalPrice = _dTotalPrice + value;
            }
        }
        public string _strItem = string.Empty;
        public string StrItem
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    _strErrorName = "물건이 선택되지 않았습니다.";
                }
                else
                {
                    _strItem = value;
                }
            }
        }

        public int _iRate = 0;
        public int IRate
        {
            set
            {
                if (value > 20)
                {
                    _strErrorName = "사장님만 가능한 할인입니다.";
                }
                else
                {
                    _iRate = value;
                }
            }
        }

        private int _iCount = 0;
        public int ICount
        {
            set
            {
                if (value > 5)
                {
                    _strErrorName = "개별 물품은 5개 이상 살 수 없습니다.";
                }
                else if (value == 0)
                {
                    _strErrorName = "물품의 개수가 0개 입니다.";
                }
                else
                {
                    _iCount = value;
                }
            }
        }

        private string _strErrorName = string.Empty;
        public string StrErrorName
        {
            get
            {
                return _strErrorName;
            }
        }

        
    }

    partial class cData
    {
        public double fitemPrice()
        {
            double dPrice = 0;

            int iItemPrice = 0;

            if (String.IsNullOrEmpty(_strErrorName)) // Error가 없으면 정상 값들을 받는다
            {
                iItemPrice = (int) Enum.Parse(typeof(EnumItem), _strItem);

                dPrice = iItemPrice - Math.Round((double)iItemPrice * (double)_iRate / 100, 2);
            }
            return dPrice * _iCount;
        }
    }

    partial class cData
    {
        public string fResult(double dPrice)
        {
            if(_iRate == 0)
            {
                return string.Format("{0} X {1} : {2}원", _strItem, _iCount, dPrice);
            }
            else
            {
                return string.Format("{0} X {1} : {2}원 (할인율 : {3}%)", _strItem, _iCount, dPrice, _iRate);
            }
        }

        public void fDataResult()
        {
            _strErrorName = string.Empty;
            _strItem = string.Empty;
            _iRate = 0;
            _iCount = 0;
        }
    }
}
