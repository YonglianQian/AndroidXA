echo "abcd"
echo $key1
echo $key2
echo $key1+$key2
echo $APPCENTER_OUTPUT_DIRECTORY
echo "............"
ls /Users/runner/Library/Android/sdk/build-tools/29.0.2/
echo "................"
/Users/runner/Library/Android/sdk/build-tools/29.0.2/apksigner verify --verbose --print-certs $APPCENTER_OUTPUT_DIRECTORY/com.companyname.androidxa.apk
echo "-----------------"