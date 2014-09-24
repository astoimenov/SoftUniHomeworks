<?php include '../../head.php';


$somepath = getcwd();
$directories = array_filter( scandir( $somepath ), 'is_dir' );

function makeFoldersDropdown( $directories ) {
    // $dirs = scandir( $directories[$num] );
    echo '<li><a href="../../">Parent directory</a></li>';
    for ( $i = 2; $i < count( $directories ) + 1; $i += 1 ) {
        echo '<li><a href="' . $directories[$i] . '">' . $directories[$i] . '</a>
                </li>';
    }
}
?>
    <section>
        <ul>
        <?php makeFoldersDropdown( $directories ); ?>
        </ul>
    </section>
<?php include '../../foot.php'; ?>
