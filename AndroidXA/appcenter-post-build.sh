echo "-----------Test-----pwd--ls--"
pwd
ls

echo "---APPCENTER_SOURCE-DIRECTORY-- ls"
echo $APPCENTER_SOURCE_DIRECTORY
ls $APPCENTER_SOURCE_DIRECTORY

echo "----APPCENTER_OUTPUT_DIRECTOYR---ls"
echo $APPCENTER_OUTPUT_DIRECTORY
ls $APPCENTER_OUTPUT_DIRECTORY

echo "------test-----"
ls /Users/runner/work/1/s/
echo "-----test1---"
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

