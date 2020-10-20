echo "-----test1---"
##echo "zhushi"
echo "-----key1----"
echo $key1
echo "----key2-----"
echo $key2
echo "........."
echo $APPCENTER_KEYSTORE_PASSWORD
echo $APPCENTER_KEY_ALIAS
echo $APPCENTER_KEY_PASSWORD


#echo ".......verify the Release build Apk file........."
#$ANDROID_HOME/build-tools/29.0.2/apksigner verify --verbose --print-certs $APPCENTER_OUTPUT_DIRECTORY/com.companyname.androidxa.apk
#echo "------Start signing-----------"
#cd $APPCENTER_OUTPUT_DIRECTORY
#echo "1.-------zipalign-------"
#$ANDROID_HOME/build-tools/29.0.2/zipalign -v -p 4 com.companyname.androidxa.apk my-app-unsigned-aligned.apk
#echo "2.-------remove original apk------"
#rm com.companyname.androidxa.apk
#echo "3.-------signing-------"
#$ANDROID_HOME/build-tools/29.0.2/apksigner sign --ks $APPCENTER_SOURCE_DIRECTORY/AndroidXA/my-release-key.jks --ks-pass pass:"123456" --out com.companyname.androidxa.apk my-app-unsigned-#aligned.apk
#echo "4.-----remove cached file------"
#rm my-app-unsigned-aligned.apk
#echo "5.----completed, verify it----"
#$ANDROID_HOME/build-tools/29.0.2/apksigner verify --verbose --print-certs com.companyname.androidxa.apk

