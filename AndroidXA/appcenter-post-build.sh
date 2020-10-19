echo "abcd"
echo $key1
echo $key2
echo $key1+$key2
echo $APPCENTER_OUTPUT_DIRECTORY
echo "list current directory............"
ls
echo "................"
/Users/runner/Library/Android/sdk/build-tools/29.0.2/apksigner verify --verbose --print-certs $APPCENTER_OUTPUT_DIRECTORY/com.companyname.androidxa.apk
echo "------Start signing-----------"
cd $APPCENTER_OUTPUT_DIRECTORY
ls
echo "1.-------zipalign-------"
/Users/runner/Library/Android/sdk/build-tools/29.0.2/zipalign -v -p 4 com.companyname.androidxa.apk my-app-unsigned-aligned.apk
echo "2. remove original apk........"
rm com.companyname.androidxa.apk
echo "3.-------signing........."
/Users/runner/Library/Android/sdk/build-tools/29.0.2/apksigner sign --ks /Users/runner/work/1/s/AndroidXA/my-release-key.jks --ks-pass pass:"123456" --out com.companyname.androidxa.apk my-app-unsigned-aligned.apk
echo "4.5 -----ls"
rm my-app-unsigned-aligned.apk
ls
echo "4. completed, verify it"
/Users/runner/Library/Android/sdk/build-tools/29.0.2/apksigner verify --verbose --print-certs com.companyname.androidxa.apk

