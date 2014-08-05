REM msbuild /target:publish /property:configuration=Release;CreateWebPageOnPublish=true;PublishDir=.\publish\;PublishUrl=.\publish\ /p:BuildingProject=true

REM msbuild /target:rebuild;publish /property:configuration=Release;PublishDir=.\publish\;PublishUrl=.\publish\ /property:CreateWebPageOnPublish=true

msbuild /target:publish /property:configuration=Release;PublishDir=.\publish\