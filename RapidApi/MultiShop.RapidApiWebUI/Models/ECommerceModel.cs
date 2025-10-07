namespace MultiShop.RapidApiWebUI.Models
{
    public class ECommerceModel
    {
        public class Rootobject
        {
            public string status { get; set; }
            public string request_id { get; set; }
            public Data data { get; set; }
        }

        public class Data
        {
            public Product[] products { get; set; }
            public object[] sponsored_products { get; set; }
            public object[] filters { get; set; }
            public string q { get; set; }
        }

        public class Product
        {
            public string product_id { get; set; }
            public string product_title { get; set; }
            public string product_description { get; set; }
            public string[] product_photos { get; set; }
            public Product_Videos[] product_videos { get; set; }
            public Product_Attributes product_attributes { get; set; }
            public float? product_rating { get; set; } // ⭐ yıldız puanı
            public int? product_num_reviews { get; set; } // ⭐ yorum sayısı
            public string product_page_url { get; set; }
            public int? product_num_offers { get; set; }
            public string[] typical_price_range { get; set; }
            public Current_Product_Variant_Properties current_product_variant_properties { get; set; }
            public Product_Variants product_variants { get; set; }
            public Reviews_Insights reviews_insights { get; set; }
            public Offer offer { get; set; }
        }

        public class Product_Attributes
        {
            public string SIMCard { get; set; }
            public string Buttons { get; set; }
            public string SIMSlots { get; set; }
            public string SIMSupport { get; set; }
            public string Sensors { get; set; }
            public string FrontCamRes { get; set; }
            public string FrontCamVideoRes { get; set; }
            public string FrontCamAperture { get; set; }
            public string MainCamRes { get; set; }
            public string RearCamZoom { get; set; }
            public string StillImageResolution { get; set; }
            public string UltrawideCamRes { get; set; }
            public string RearCamVideoRes { get; set; }
            public string FocusAdjustment { get; set; }
            public string RearCamAperture { get; set; }
            public string CameraLightSource { get; set; }
            public string LensType { get; set; }
            public string OptSensor { get; set; }
            public string RearCamLensCount { get; set; }
            public string MinFocalLen { get; set; }
            public string RearCamHighlights { get; set; }
            public string SupportedOS { get; set; }
            public string OSVersion { get; set; }
            public string DispSize { get; set; }
            public string DispResolution { get; set; }
            public string DispPixelDensity { get; set; }
            public string DispType { get; set; }
            public string DispAspectRatio { get; set; }
            public string DispBrightness { get; set; }
            public string DispRefreshRate { get; set; }
            public string DispHighlights { get; set; }
            public string BatteryLife { get; set; }
            public string BatteryChargeTech { get; set; }
            public string BatteryChargeTime { get; set; }
            public string BatteryCapacity { get; set; }
            public string BatteryChargePower { get; set; }
            public string BatteryStandby { get; set; }
            public string RemovableBattery { get; set; }
            public string BroadbandGeneration { get; set; }
            public string PortsandInterfaces { get; set; }
            public string WiFi { get; set; }
            public string GPS { get; set; }
            public string WirelessInterface { get; set; }
            public string Bluetooth { get; set; }
            public string DataTransmission { get; set; }
            public string NFC { get; set; }
            public string SatelliteLink { get; set; }
            public string LTEBand { get; set; }
            public string Dimensions { get; set; }
            public string Durability { get; set; }
            public string Weight { get; set; }
            public string Material { get; set; }
            public string DesignHighlights { get; set; }
            public string FormFactor { get; set; }
            public string HeadphoneJack { get; set; }
            public string HearingAidCompatible { get; set; }
            public string Speaker { get; set; }
            public string AudioPlayback { get; set; }
            public string VideoPlayback { get; set; }
            public string Microphone { get; set; }
            public string VideoStreaming { get; set; }
            public string IncludedAccessories { get; set; }
            public string StylusSupport { get; set; }
            public string SupportedAccessories { get; set; }
            public string ExpandableStorage { get; set; }
            public string RemovableStorage { get; set; }
            public string StorageType { get; set; }
            public string ProcessorType { get; set; }
            public string CPUCores { get; set; }
            public string GPU { get; set; }
            public string Processor { get; set; }
            public string CPUClockSpeed { get; set; }
            public string SecurityHighlights { get; set; }
            public string TypicalUsers { get; set; }
            public string HardwareSensors { get; set; }
            public string TalkTime { get; set; }
            public string FrontCamZoom { get; set; }
            public string StillImgRes { get; set; }
            public string DigVideoFormats { get; set; }
            public string LensAperture { get; set; }
            public string MacroCamRes { get; set; }
            public string TelephotoCamRes { get; set; }
            public string CamLightSource { get; set; }
            public string DigZoom { get; set; }
            public string LensCount { get; set; }
            public string MinFocalLength { get; set; }
            public string OptSensorType { get; set; }
            public string RearDepthSensor { get; set; }
            public string OLEDDisplay { get; set; }
            public string BroadbandGen { get; set; }
            public string MobBroadbandGen { get; set; }
            public string ConnType { get; set; }
            public string DataTrans { get; set; }
            public string SatLink { get; set; }
            public string BTProfiles { get; set; }
            public string Quadband { get; set; }
            public string WaterResistant { get; set; }
            public string BodyMaterial { get; set; }
            public string Height { get; set; }
            public string Resistance { get; set; }
            public string Bezelless { get; set; }
            public string WithKeyboard { get; set; }
            public string HearingAidComp { get; set; }
            public string InclAccessories { get; set; }
            public string SupportAccessories { get; set; }
            public string Smartphone { get; set; }
            public string TopUseCases { get; set; }
            public string NumberofCPUCores { get; set; }
            public string EPEATRating { get; set; }
            public string Capacity { get; set; }
            public string WithExpandableStorage { get; set; }
            public string SIMType { get; set; }
            public string DigitalZoom { get; set; }
            public string Zoom { get; set; }
            public string BluetoothProfiles { get; set; }
        }

        public class Current_Product_Variant_Properties
        {
            public string Colour { get; set; }
            public string StorageCapacity { get; set; }
        }

        public class Product_Variants
        {
            public Colour[] Colour { get; set; }
            public StorageCapacity[] StorageCapacity { get; set; }
        }

        public class Colour
        {
            public string name { get; set; }
            public string thumbnail { get; set; }
            public string product_id { get; set; }
        }

        public class StorageCapacity
        {
            public string name { get; set; }
            public string product_id { get; set; }
        }

        public class Reviews_Insights
        {
        }

        public class Offer
        {
            public string offer_id { get; set; }
            public string offer_title { get; set; }
            public string offer_page_url { get; set; }
            public string price { get; set; }
            public object original_price { get; set; }
            public bool on_sale { get; set; }
            public string shipping { get; set; }
            public string returns { get; set; }
            public string product_condition { get; set; }
            public string store_name { get; set; }
            public string store_rating { get; set; }
            public int store_review_count { get; set; }
            public object store_reviews_page_url { get; set; }
            public string store_favicon { get; set; }
            public object payment_methods { get; set; }
        }

        public class Product_Videos
        {
            public string title { get; set; }
            public string url { get; set; }
            public string source { get; set; }
            public string publisher { get; set; }
            public string thumbnail { get; set; }
            public int duration_ms { get; set; }
            public string preview_url { get; set; }
        }
    }
}
