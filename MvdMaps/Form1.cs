using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.ToolTips;
using GMap.NET.WindowsForms.Markers;
using System.IO;

namespace MvdMaps
{
    public partial class Form1 : Form
    {
        List<GMarkerGoogle> newMarkers = new List<GMarkerGoogle>();
        List<GMarkerGoogle> allMarkers = new List<GMarkerGoogle>();
        GMapOverlay markersOverlay = new GMapOverlay();
        public Form1()
        {
            InitializeComponent();
        }

        private void drawBorders()
        {
            GMapOverlay overlay = new GMapOverlay();
            List<PointLatLng> list = new List<PointLatLng>(); //Теперь создаем коллекцию, для хранения точек полигона
            list.Add(new PointLatLng(59.735935, 30.629822));
            list.Add(new PointLatLng(59.735607, 30.621769));
            list.Add(new PointLatLng(59.735856, 30.621404));
            list.Add(new PointLatLng(59.735430, 30.619490));
            list.Add(new PointLatLng(59.735377, 30.616579));
            list.Add(new PointLatLng(59.735282, 30.616622));
            list.Add(new PointLatLng(59.730866, 30.617260));
            list.Add(new PointLatLng(59.730631, 30.607046));
            list.Add(new PointLatLng(59.730511, 30.605021));
            list.Add(new PointLatLng(59.730182, 30.601159));
            list.Add(new PointLatLng(59.730013, 30.593909));
            list.Add(new PointLatLng(59.729609, 30.593402));
            list.Add(new PointLatLng(59.729248, 30.592847));
            list.Add(new PointLatLng(59.729148, 30.592378));
            list.Add(new PointLatLng(59.729082, 30.591533));
            list.Add(new PointLatLng(59.729091, 30.591225));
            list.Add(new PointLatLng(59.730077, 30.576509));
            list.Add(new PointLatLng(59.704952, 30.564210));
            list.Add(new PointLatLng(59.707543, 30.531145));
            list.Add(new PointLatLng(59.704630, 30.530282));
            list.Add(new PointLatLng(59.704483, 30.524798));
            list.Add(new PointLatLng(59.700260, 30.524514));

            list.Add(new PointLatLng(59.696764, 30.519900));
            list.Add(new PointLatLng(59.696037, 30.523075));
            list.Add(new PointLatLng(59.693562, 30.523944));
            list.Add(new PointLatLng(59.690939, 30.519908));
            list.Add(new PointLatLng(59.688886, 30.488748));
            list.Add(new PointLatLng(59.684875, 30.486035));
            list.Add(new PointLatLng(59.680924, 30.476967));
            list.Add(new PointLatLng(59.677803, 30.478001));
            list.Add(new PointLatLng(59.677825, 30.477974));
            list.Add(new PointLatLng(59.679217, 30.487245));
            list.Add(new PointLatLng(59.670539, 30.489424));

            list.Add(new PointLatLng(59.669095, 30.502503));
            list.Add(new PointLatLng(59.646187, 30.504956));
            list.Add(new PointLatLng(59.638135, 30.479234));
            list.Add(new PointLatLng(59.633389, 30.484136));
            list.Add(new PointLatLng(59.630292, 30.478424));
            list.Add(new PointLatLng(59.621626, 30.489858));
            list.Add(new PointLatLng(59.617704, 30.480066));
            list.Add(new PointLatLng(59.610067, 30.477625));
            list.Add(new PointLatLng(59.602845, 30.484157));
            list.Add(new PointLatLng(59.588397, 30.483351));
            list.Add(new PointLatLng(59.573125, 30.498848));

            list.Add(new PointLatLng(59.577253, 30.524524));
            list.Add(new PointLatLng(59.557646, 30.508988));
            list.Add(new PointLatLng(59.544608, 30.480535));
            list.Add(new PointLatLng(59.500826, 30.454981));
            list.Add(new PointLatLng(59.498902, 30.433380));
            list.Add(new PointLatLng(59.488458, 30.431000));
            list.Add(new PointLatLng(59.476669, 30.516134));
            list.Add(new PointLatLng(59.446351, 30.538200));
            list.Add(new PointLatLng(59.431411, 30.544737));
            list.Add(new PointLatLng(59.425099, 30.571784));
            list.Add(new PointLatLng(59.412847, 30.579956));

            list.Add(new PointLatLng(59.398100, 30.569766));
            list.Add(new PointLatLng(59.379616, 30.570597));
            list.Add(new PointLatLng(59.371098, 30.560005));
            list.Add(new PointLatLng(59.356558, 30.556354));
            list.Add(new PointLatLng(59.340724, 30.571069));
            list.Add(new PointLatLng(59.308881, 30.578035));
            list.Add(new PointLatLng(59.307636, 30.603724));
            list.Add(new PointLatLng(59.271938, 30.614344));
            list.Add(new PointLatLng(59.264827, 30.641593));
            list.Add(new PointLatLng(59.264849, 30.642105));
            list.Add(new PointLatLng(59.248573, 30.609879));

            list.Add(new PointLatLng(59.238982, 30.628651));
            list.Add(new PointLatLng(59.218539, 30.636814));
            list.Add(new PointLatLng(59.208525, 30.647412));
            list.Add(new PointLatLng(59.204101, 30.672261));
            list.Add(new PointLatLng(59.186306, 30.688632));
            list.Add(new PointLatLng(59.143796, 30.674368));
            list.Add(new PointLatLng(59.058692, 30.615557));
            list.Add(new PointLatLng(59.052644, 30.714837));
            list.Add(new PointLatLng(59.086012, 30.836129));
            list.Add(new PointLatLng(59.097973, 30.842475));
            list.Add(new PointLatLng(59.101449, 30.858021));

            list.Add(new PointLatLng(59.093206, 30.874010));
            list.Add(new PointLatLng(59.101905, 30.896379));
            list.Add(new PointLatLng(59.102637, 30.908521));
            list.Add(new PointLatLng(59.092179, 30.898761));
            list.Add(new PointLatLng(59.077720, 30.898207));
            list.Add(new PointLatLng(59.077695, 30.917131));
            list.Add(new PointLatLng(59.041544, 30.919825));
            list.Add(new PointLatLng(59.033528, 30.917547));
            list.Add(new PointLatLng(59.026087, 30.897964));
            list.Add(new PointLatLng(59.008277, 30.897462));
            list.Add(new PointLatLng(59.003270, 30.935524));

            list.Add(new PointLatLng(59.014539, 30.925111));
            list.Add(new PointLatLng(59.015153, 30.948747));
            list.Add(new PointLatLng(59.024671, 30.979286));
            list.Add(new PointLatLng(59.035359, 30.985611));
            list.Add(new PointLatLng(59.042798, 31.017126));
            list.Add(new PointLatLng(59.057136, 31.029595));
            list.Add(new PointLatLng(59.069114, 31.058727));
            list.Add(new PointLatLng(59.068110, 31.079119));
            list.Add(new PointLatLng(59.088314, 31.106352));
            list.Add(new PointLatLng(59.089796, 31.131134));
            list.Add(new PointLatLng(59.085278, 31.161243));

            list.Add(new PointLatLng(59.079276, 31.173365));
            list.Add(new PointLatLng(59.057178, 31.171018));
            list.Add(new PointLatLng(59.051448, 31.186899));
            list.Add(new PointLatLng(59.042501, 31.191049));
            list.Add(new PointLatLng(59.010968, 31.238451));
            list.Add(new PointLatLng(59.009800, 31.273282));
            list.Add(new PointLatLng(59.006250, 31.296095));
            list.Add(new PointLatLng(59.012349, 31.314983));
            list.Add(new PointLatLng(59.022702, 31.319577));
            list.Add(new PointLatLng(59.027809, 31.340683));
            list.Add(new PointLatLng(59.030354, 31.357646));

            list.Add(new PointLatLng(59.047140, 31.375836));
            list.Add(new PointLatLng(59.049516, 31.365801));
            list.Add(new PointLatLng(59.053562, 31.371938));
            list.Add(new PointLatLng(59.054193, 31.381322));
            list.Add(new PointLatLng(59.060428, 31.389840));
            list.Add(new PointLatLng(59.065028, 31.410634));
            list.Add(new PointLatLng(59.082020, 31.438205));
            list.Add(new PointLatLng(59.096408, 31.475306));
            list.Add(new PointLatLng(59.111086, 31.488804));
            list.Add(new PointLatLng(59.123646, 31.476821));
            list.Add(new PointLatLng(59.132424, 31.495016));

            list.Add(new PointLatLng(59.154058, 31.500526));
            list.Add(new PointLatLng(59.164201, 31.478797));
            list.Add(new PointLatLng(59.186894, 31.509481));
            list.Add(new PointLatLng(59.210526, 31.525809));
            list.Add(new PointLatLng(59.203938, 31.559899));
            list.Add(new PointLatLng(59.212981, 31.575013));
            list.Add(new PointLatLng(59.229281, 31.582973));
            list.Add(new PointLatLng(59.279850, 31.537549));
            list.Add(new PointLatLng(59.283606, 31.538162));
            list.Add(new PointLatLng(59.290335, 31.548935));
            list.Add(new PointLatLng(59.297277, 31.569095));

            list.Add(new PointLatLng(59.307008, 31.561557));
            list.Add(new PointLatLng(59.314133, 31.552334));
            list.Add(new PointLatLng(59.324604, 31.547599));
            list.Add(new PointLatLng(59.343425, 31.553305));
            list.Add(new PointLatLng(59.359889, 31.554760));
            list.Add(new PointLatLng(59.370526, 31.578432));
            list.Add(new PointLatLng(59.371206, 31.609278));
            list.Add(new PointLatLng(59.376061, 31.609279));
            list.Add(new PointLatLng(59.417512, 31.577227));
            list.Add(new PointLatLng(59.429706, 31.595712));
            list.Add(new PointLatLng(59.442624, 31.585600));

            list.Add(new PointLatLng(59.458187, 31.580976));
            list.Add(new PointLatLng(59.475659, 31.607347));
            list.Add(new PointLatLng(59.536782, 31.593003));
            list.Add(new PointLatLng(59.530357, 31.582982));
            list.Add(new PointLatLng(59.524105, 31.552617));
            list.Add(new PointLatLng(59.499575, 31.537937));
            list.Add(new PointLatLng(59.498222, 31.524937));
            list.Add(new PointLatLng(59.527317, 31.501244));
            list.Add(new PointLatLng(59.536621, 31.499233));
            list.Add(new PointLatLng(59.543216, 31.486543));
            list.Add(new PointLatLng(59.536769, 31.450511));

            list.Add(new PointLatLng(59.538484, 31.368497));
            list.Add(new PointLatLng(59.519539, 31.354826));
            list.Add(new PointLatLng(59.520038, 31.320814));
            list.Add(new PointLatLng(59.540164, 31.316447));
            list.Add(new PointLatLng(59.548782, 31.298077));
            list.Add(new PointLatLng(59.551657, 31.296735));
            list.Add(new PointLatLng(59.555550, 31.303069));
            list.Add(new PointLatLng(59.559779, 31.303061));
            list.Add(new PointLatLng(59.566367, 31.287686));
            list.Add(new PointLatLng(59.587994, 31.270440));
            list.Add(new PointLatLng(59.612128, 31.267428));

            list.Add(new PointLatLng(59.617191, 31.269427));
            list.Add(new PointLatLng(59.624449, 31.276099));
            list.Add(new PointLatLng(59.627318, 31.275097));
            list.Add(new PointLatLng(59.630859, 31.254733));
            list.Add(new PointLatLng(59.641996, 31.246041));
            list.Add(new PointLatLng(59.651280, 31.248368));
            list.Add(new PointLatLng(59.634209, 31.170705));
            list.Add(new PointLatLng(59.628817, 31.162357));
            list.Add(new PointLatLng(59.625787, 31.069312));
            list.Add(new PointLatLng(59.633541, 31.061965));
            list.Add(new PointLatLng(59.633694, 31.028274));

            list.Add(new PointLatLng(59.638567, 31.004575));
            list.Add(new PointLatLng(59.632816, 30.983910));
            list.Add(new PointLatLng(59.638938, 30.963602));
            list.Add(new PointLatLng(59.642137, 30.959596));
            list.Add(new PointLatLng(59.655614, 30.954569));
            list.Add(new PointLatLng(59.662171, 30.930537));
            list.Add(new PointLatLng(59.670762, 30.929215));
            list.Add(new PointLatLng(59.677852, 30.955552));
            list.Add(new PointLatLng(59.718082, 30.947889));
            list.Add(new PointLatLng(59.722795, 30.934552));
            list.Add(new PointLatLng(59.716071, 30.895526));

            list.Add(new PointLatLng(59.720780, 30.870507));
            list.Add(new PointLatLng(59.738269, 30.860836));
            list.Add(new PointLatLng(59.730022, 30.816801));
            list.Add(new PointLatLng(59.714888, 30.817487));
            list.Add(new PointLatLng(59.715726, 30.808483));
            list.Add(new PointLatLng(59.726821, 30.801127));
            list.Add(new PointLatLng(59.733710, 30.788771));
            list.Add(new PointLatLng(59.730167, 30.769095));
            list.Add(new PointLatLng(59.733188, 30.761413));
            list.Add(new PointLatLng(59.734826, 30.759746));
            list.Add(new PointLatLng(59.739225, 30.761864));

            list.Add(new PointLatLng(59.747513, 30.710905));
            list.Add(new PointLatLng(59.747077, 30.703681));
            list.Add(new PointLatLng(59.729317, 30.679704));
            list.Add(new PointLatLng(59.725387, 30.683458));
            list.Add(new PointLatLng(59.721451, 30.648524));
            list.Add(new PointLatLng(59.735935, 30.629822));

            GMapPolygon mapPolygon = new GMapPolygon(list, "polygon"); //создаем 
            mapPolygon.Fill = new SolidBrush(Color.Transparent); //красим полигон.
            mapPolygon.Stroke = new Pen(Color.Red, 2); //делаем границы зеленые и толстыми.
            overlay.Polygons.Add(mapPolygon);
            gMapControl1.Overlays.Add(overlay); //Выводим полигон на карту.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.CacheOnly;//use cashed info
            gMapControl1.Bearing = 0;
            gMapControl1.ShowCenter = false;
            gMapControl1.MapProvider =GMap.NET.MapProviders.GMapProviders.GoogleTerrainMap;
            GMap.NET.GMaps.Instance.Mode =GMap.NET.AccessMode.ServerOnly;

            //открытия определенного места на карте через указание координат
            gMapControl1.Position = new GMap.NET.PointLatLng(59.540664, 30.877719);

            gMapControl1.CanDragMap = true; //Открываем доступ к манипулированию картой мышью через зажатие правой кнопкой(по умолчанию).
            gMapControl1.DragButton = MouseButtons.Left; //Меняем кнопку манипулирования с правой кнопки(по умолчанию) на левую кнопку мыши.
            gMapControl1.GrayScaleMode = true;
            gMapControl1.MaxZoom = 17; //Устанавливаем максимальное приближение.
            gMapControl1.MinZoom = 10; //Устанавливаем минимальное приближение.
            gMapControl1.MouseWheelZoomType = MouseWheelZoomType.MousePositionAndCenter; //Устанавливаем центр приближения/удаления курсор мыши.          
            gMapControl1.PolygonsEnabled = true; //Открываем отображение полигонов на карте.
            gMapControl1.MarkersEnabled = true; //Открываем отображение маркеров на карте.
            gMapControl1.NegativeMode = false; //Отказываемся от негативного режима
            gMapControl1.ShowTileGridLines = false; //Скрываем внешнюю сетку карты с заголовками
            gMapControl1.Dock = DockStyle.Fill; //Закрепляем контрол внутри формы, чтобы размеры контрола изменялись вместе с размером формы.
            GMaps.Instance.Mode = AccessMode.ServerOnly;


            drawBorders();
            gMapControl1.Zoom = 12;

            //Создаем новый список маркеров, с указанием компонента 
            //в котором они будут использоваться и названием списка           

            StreamReader sr = new StreamReader("markers.txt");
            //Инициализация нового КРАСНОГО маркера, с указанием его координат
            string line;
            while(!sr.EndOfStream) {              
                line = sr.ReadLine();
                if (line.Split(';')[2] == "g")
                {
                    GMap.NET.WindowsForms.Markers.GMarkerGoogle marker =
                    new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                    new GMap.NET.PointLatLng(Convert.ToDouble(line.Split(';')[0]), Convert.ToDouble(line.Split(';')[1])), GMarkerGoogleType.green);
                    marker.ToolTip =
                        new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker);
                    //Текст отображаемый при наведении на маркер
                    //markerR.ToolTipText = "Красная площадь";

                    //Добавляем маркеры в список маркеров
                    markersOverlay.Markers.Add(marker);
                    allMarkers.Add(marker);
                }
                else
                {
                    GMap.NET.WindowsForms.Markers.GMarkerGoogle marker =
                                        new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                                        new GMap.NET.PointLatLng(Convert.ToDouble(line.Split(';')[0]), Convert.ToDouble(line.Split(';')[1])), GMarkerGoogleType.red);
                    marker.ToolTip =
                        new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker);
                    //Текст отображаемый при наведении на маркер
                    //markerR.ToolTipText = "Красная площадь";

                    //Добавляем маркеры в список маркеров
                    markersOverlay.Markers.Add(marker);
                    allMarkers.Add(marker);
                }
                //Добавляем в компонент, список маркеров 
            }
            gMapControl1.Overlays.Add(markersOverlay);
            gMapControl1.Zoom += 1;
            gMapControl1.Zoom -= 1;
        }

        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBoxManager.Yes = "Зеленый";
            MessageBoxManager.No = "Красный";
            MessageBoxManager.Cancel = "Отмена";
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                DialogResult dr;
                double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
                double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;
                dr = MessageBox.Show("Вы действительно хотите установить новый маркер?\nЗеленый - безопасный город, красный - частная камера", "Установка маркера",
                    MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Yes)
                {
                    GMap.NET.WindowsForms.Markers.GMarkerGoogle marker =
                new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                new GMap.NET.PointLatLng(lat,lng), GMarkerGoogleType.green);
                    markersOverlay.Markers.Add(marker);
                    gMapControl1.Overlays.Remove(markersOverlay);
                    gMapControl1.Overlays.Add(markersOverlay);
                    allMarkers.Add(marker);
                    if (gMapControl1.Zoom < 17)
                    {
                        gMapControl1.Zoom += 1;
                        gMapControl1.Zoom -= 1;
                    }
                    else
                    {
                        gMapControl1.Zoom -= 1;
                        gMapControl1.Zoom += 1;
                    }
                }  
                else if (dr == DialogResult.No)
                {
                    GMap.NET.WindowsForms.Markers.GMarkerGoogle marker =
                new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                new GMap.NET.PointLatLng(lat, lng), GMarkerGoogleType.red);
                    markersOverlay.Markers.Add(marker);
                    gMapControl1.Overlays.Remove(markersOverlay);
                    gMapControl1.Overlays.Add(markersOverlay);
                    allMarkers.Add(marker);
                    if (gMapControl1.Zoom < 17)
                    {
                        gMapControl1.Zoom += 1;
                        gMapControl1.Zoom -= 1;
                    }
                    else
                    {
                        gMapControl1.Zoom -= 1;
                        gMapControl1.Zoom += 1;
                    }
                }
            }         
        }

        private void gMapControl1_OnPolygonDoubleClick(GMapPolygon item, MouseEventArgs e)
        {
            
        }

        private void gMapControl1_OnMarkerDoubleClick(GMapMarker item, MouseEventArgs e)
        {
            
        }

        private void gMapControl1_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            MessageBoxManager.Yes = "Да";
            MessageBoxManager.No = "Нет";
            if (MessageBox.Show("Вы действуительно хотите удалить этот маркер?", "Удаление маркера", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                markersOverlay.Markers.Remove(item);
                gMapControl1.Overlays.Remove(markersOverlay);
                gMapControl1.Overlays.Add(markersOverlay);
                allMarkers.Remove((GMarkerGoogle)item);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            string colorLetter;
            StreamWriter sw = new StreamWriter("markers.txt");
            for (int i = 0; i < allMarkers.Count; i++)
            {
                if (allMarkers[i].Type == GMarkerGoogleType.green)
                    colorLetter = "g";
                else
                    colorLetter = "r";
                sw.WriteLine(allMarkers[i].Position.Lat.ToString()+";"+ allMarkers[i].Position.Lng.ToString()+";"+colorLetter);                
            }
            sw.Close();
        }
    }
}
