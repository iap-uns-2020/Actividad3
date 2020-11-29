using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ZXing;
using ZXing.QrCode;
using Compression;
using LevelStorage.Presenter;

namespace QRCodeReader.View{
	public class QRCodeReader : MonoBehaviour, IQRCodeReader{
		private const string NEWLEVELADDEDMSG = "NUEVO NIVEL AGREGADO!";
		private ILevelStorageManagerPresenter levelStorageManagerPresenter;
		private IStringCompression stringCompression;
		private WebCamTexture camTexture;
		public Text textField;
		public RawImage rawImage;

		void Start(){
			levelStorageManagerPresenter = new LevelStorageManagerPresenter();
			stringCompression = new StringCompression();
			camTexture = new WebCamTexture();
			rawImage.texture = camTexture;
	        rawImage.material.mainTexture = camTexture;
			if (camTexture != null) {
		    	camTexture.Play();
		  	}
		  	InvokeRepeating("DecodeQR", 0 ,1 );
		}

		public void DecodeQR(){
			try{
	    		IBarcodeReader barcodeReader = new BarcodeReader ();
	    		var result = barcodeReader.Decode(camTexture.GetPixels32(),camTexture.width, camTexture.height);   		
	    		if (result != null) {
	    			levelStorageManagerPresenter.Save(stringCompression.Decompress(result.Text));
	     			textField.text = NEWLEVELADDEDMSG;
	     			camTexture.Stop();
	    		}  	
	    	}catch(Exception ex) { Debug.LogWarning (ex.Message); }
		}
	}	
}


