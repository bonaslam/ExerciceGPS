using System;
using System.Device.Location;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceGPS
{
    class Program
    {
        struct CoordonneeGPS
        {
            public string nom;
            public double latitude;
            public double longitude;
        }

         

        static void Main(string[] args)
        {
            CoordonneeGPS tln = new CoordonneeGPS();
            
            Console.ReadKey();
        }

        /// <summary>
        /// Méthode qui initialise un point GPS en 
        /// - valorisant l'attribut nom avec le paramètre paramNom
        /// - valorisant l'attribut latitude avec le paramètre paramLatitude 
        /// - valorisant l'attribut longitude avec le paramètre paramLongitude 
        /// </summary>
        /// <param name="unPointGPS">le point GPS auquel il faut attibuer sa latitude et sa longitude</param>
        /// <param name="paramNom">nom de la ville correspondant au point GPS</param>
        /// <param name="paramLatitude">latitude du point GPS</param>
        /// <param name="paramLongitude">longitude du point GPS</param>
        static void InitCoordonneeGPS(ref CoordonneeGPS unPointGPS, string paramNom, double paramLatitude, double paramLongitude)
        {
           
        }

        /// <summary>
        /// retourne le nom de la ville ayant la plus petite latitude des 2 points passés en paramètre
        /// </summary>
        /// <param name="point1">coordonnées GPS du premier point</param>
        /// <param name="point2">coordonnées GPS du deuxième point</param>
        /// <returns>le nom d'une ville</returns>
        static string PlusPetiteLatitude(CoordonneeGPS point1, CoordonneeGPS point2)
        {           

        }

        /// <summary>
        /// retourne vrai si le point GPS passé en paramètre est dans l'hémisphère sud
        /// Un point GPS est dans l'hémisphère sud si sa latitude est inférieure ou égale à 0
        /// </summary>
        /// <param name="unPoint">point GPS</param>
        /// <returns>vrai si le point est dans l'hémisphère sud</returns>
        static bool EstDansHemisphereSud(CoordonneeGPS unPoint)
        {
           
        }

        /// <summary>
        /// Cette fonction retourne vrai si le point1 est plus près de l'équateur que le point2
        /// </summary>
        /// <param name="point1">coordonnées GPS du premier point</param>
        /// <param name="point2">coordonnées GPS du deuxième point</param>
        /// <returns>vrai si point1 plus près de léquateur que point2</returns>
        static bool PlusPresEquateur(CoordonneeGPS point1, CoordonneeGPS point2)
        {
                      
        }

        /// <summary>
        /// Retourne la distance en mètres entre 2 points 
        /// </summary>
        /// <param name="point1">coordonnées GPS du premier point</param>
        /// <param name="point2">coordonnées GPS du deuxième point</param>
        /// <returns></returns>
        static double DistanceDeuxPoints(CoordonneeGPS point1, CoordonneeGPS point2)
        {
            GeoCoordinate pointGPS1 = new GeoCoordinate(point1.latitude, point1.longitude);
            GeoCoordinate pointGPS2 = new GeoCoordinate(point2.latitude, point2.longitude);
            return pointGPS1.GetDistanceTo(pointGPS2);
        }


        static void VerifieHemisphere(CoordonneeGPS point)
        {
            
        }

        /// <summary>
        /// Retourne la ville du point 2 ou du point 3 qui est la plus près du point1
        /// </summary>
        /// <param name="point1">coordonnées gps du point de référence</param>
        /// <param name="point2">coordonnées gps du premier point à vérifier</param>
        /// <param name="point3">coordonnées gps du deuxième point à vérifier</param>
        /// <returns>la ville la plus près du point 1</returns>
        static String PlusPresDe(CoordonneeGPS point1, CoordonneeGPS point2, CoordonneeGPS point3)
        {
          
        }










    }
}
