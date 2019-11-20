using System;
using Script.Hero;
using UnityEngine;
using UnityEngine.Serialization;

namespace Script
{
    public class Player: MonoBehaviour
    {
        private Yasuo _yasuo;
        public Texture2D iconHero;
        private void Awake()
        {
            _yasuo = new Yasuo()
            {
                Id = 1,
                Ten = "Yasuo",
                ThongTin = "Sinh ra và lớn lên tạo hà nội!",
                AnhDaiDien = iconHero,
                SatThuongTay = 60,
                SatThuongPhep = 0,
                Giap = 29,
                KhangPhep = 30,
                HoiChieu = 0,
                TocDanh = 0.7f,
                HoiMau = 0.3f,
                TiLeChiMang = 0,
                TocChay = 335
            };
        }

        private void Start()
        {
            Debug.Log(_yasuo.ToString());
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                _yasuo.KyNang_Q();
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                _yasuo.KyNang_W();
            }
            else if (Input.GetKeyDown(KeyCode.E))
            {
                _yasuo.KyNang_E();
            }
            else if (Input.GetKeyDown(KeyCode.R))
            {
                _yasuo.KyNang_R();
            }
        }
    }
}