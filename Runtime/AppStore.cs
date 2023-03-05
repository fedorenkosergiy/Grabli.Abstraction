namespace Grabli.Abstraction
{
	public enum AppStore
	{
		/// <summary>
		/// Dedicated to an unset value
		/// </summary>
		Undefined = 0,

		/// <summary>
		/// May be used for a custom store
		/// </summary>
		CustomSlotA = 1,

		/// <summary>
		/// <inheritdoc cref="CustomSlotA"/>
		/// </summary>
		CustomSlotB = 2,

		/// <summary>
		/// <inheritdoc cref="CustomSlotA"/>
		/// </summary>
		CustomSlotC = 3,

		/// <summary>
		/// <inheritdoc cref="CustomSlotA"/>
		/// </summary>
		CustomSlotD = 4,

		/// <summary>
		/// <inheritdoc cref="CustomSlotA"/>
		/// </summary>
		CustomSlotE = 6,

		/// <summary>
		/// <inheritdoc cref="CustomSlotA"/>
		/// </summary>
		CustomSlotF = 7,

		/// <summary>
		/// <inheritdoc cref="CustomSlotA"/>
		/// </summary>
		CustomSlotG = 8,

		/// <summary>
		/// <inheritdoc cref="CustomSlotA"/>
		/// </summary>
		CustomSlotH = 9,

		/// <summary>
		/// <inheritdoc cref="CustomSlotA"/>
		/// </summary>
		CustomSlotI = 10,

		/// <summary>
		/// https://play.google.com/store/
		/// </summary>
		GooglePlayMarket = 11,

		/// <summary>
		/// https://www.amazon.com/
		/// </summary>
		AmazonAppStore = 12,

		/// <summary>
		/// https://appgallery.huawei.com/
		/// </summary>
		HuaweiAppGallery = 13,

		/// <summary>
		/// https://www.apple.com/lae/app-store/
		/// </summary>
		AppleAppStore = 14,

		OperaMobileStore = 15,

		/// <summary>
		/// https://app.mi.com/
		/// </summary>
		XiaomiAppStore = 16,

		/// <summary>
		/// https://galaxystore.samsung.com/
		/// </summary>
		SamsungGalaxyStore = 17,
	}
}
