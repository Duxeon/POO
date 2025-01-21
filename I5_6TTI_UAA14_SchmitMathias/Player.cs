using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I5_6TTI_UAA14_SchmitMathias
{
    internal class Player
    {
        private string _pseudo;
        private byte _nbCartoucheEnPoche;
        private PaintBallGun _myPaintBallGun;

        public string Pseudo
        {
            get => _pseudo;
        }
        public byte NbCartoucheEnPoche
        {
            get => _nbCartoucheEnPoche;
            set
            {
                _nbCartoucheEnPoche = value;
            }
        }
        public PaintBallGun MyPaintBallGun
        {
            get => _myPaintBallGun;
            set
            {
                _myPaintBallGun = value;
            }
        }

        public Player(string pseudo, PaintBallGun pbg)
        {
            _pseudo = pseudo;
            _myPaintBallGun = pbg;
            _nbCartoucheEnPoche = 30;
        }

        public string Recharge()
        {
            if (_myPaintBallGun.BallesChargeur == _myPaintBallGun.TailleChargeur)
            {
                return "Le chargeur est plein";
            }
            byte r = (byte)(MyPaintBallGun.TailleChargeur - MyPaintBallGun.BallesChargeur);
            if (r > _nbCartoucheEnPoche)
            {
                r = _nbCartoucheEnPoche;
            }
            _myPaintBallGun.BallesChargeur += r;
            _nbCartoucheEnPoche -= r;
            return "Recharge de " + r + " balles dans le chargeur effectuée";
        }
        public bool Tire()
        {
            if (!MyPaintBallGun.IsVide())
            {
                MyPaintBallGun.BallesChargeur--;
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    internal class PaintBallGun
    {
        private byte _nbBallesChargeur;
        private byte _tailleChargeur;

        public byte BallesChargeur
        {
            get { return _nbBallesChargeur; }
            set { _nbBallesChargeur = value; }
        }
        public byte TailleChargeur
        {
            get => _tailleChargeur;
        }

        public PaintBallGun()
        {
            _nbBallesChargeur = 0;
            _tailleChargeur = 16;
        }

        public bool IsVide()
        {
            if (_nbBallesChargeur == 0)
            {
                return true;
            }
            return false;
        }
    }
}
